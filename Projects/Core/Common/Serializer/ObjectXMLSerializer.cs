// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectXMLSerializer.cs" company="">
//   
// </copyright>
// <summary>
//   The object xml serializer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Common.Serializer
{
    #region Using

    using System;
    using System.IO;
    using System.IO.IsolatedStorage;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Xml.Serialization;

    using global::Common.Logging;

    #endregion

    /// <summary>
    /// The object xml serializer.
    /// </summary>
    /// <typeparam name="T">
    /// Defines the type to be serialized / deserialized
    /// </typeparam>
    public static class ObjectXMLSerializer<T>
        where T : class
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Public methods and operators

        /// <summary>
        /// Loads an object from an XML file in Document format.
        /// </summary>
        /// <example>
        /// <code>
        /// serializableObject = ObjectXMLSerializer&lt;SerializableObject&gt;.Load(@"C:\XMLObjects.xml");
        /// </code>
        /// </example>
        /// <param name="path">
        /// Path of the file to load the object from.
        /// </param>
        /// <returns>
        /// Object loaded from an XML file in Document format.
        /// </returns>
        public static T Load(string path)
        {
            Logger.Trace($"Started Load() - path: {path}");
            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("Path may not be empty");
                throw new ArgumentException("Path may not be empty");
            }

            T serializableObject = LoadFromDocumentFormat(null, path, null);
            Logger.Trace($"Completed Load() - path: {path}");
            return serializableObject;
        }

        /// <summary>
        /// Loads an object from an XML file using a specified serialized format.
        /// </summary>
        /// <example>
        /// <code>
        /// serializableObject = ObjectXMLSerializer&lt;SerializableObject&gt;.Load(@"C:\XMLObjects.xml", SerializedFormat.Binary);
        /// </code>
        /// </example>
        /// <param name="path">
        /// Path of the file to load the object from.
        /// </param>
        /// <param name="serializedFormat">
        /// XML serialized format used to load the object.
        /// </param>
        /// <returns>
        /// Object loaded from an XML file using the specified serialized format.
        /// </returns>
        public static T Load(string path, SerializedFormat serializedFormat)
        {
            Logger.Trace($"Started Load() - path: {path}, serializedFormat: {serializedFormat}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("Path may not be empty");
                throw new ArgumentException("Path may not be empty");
            }

            T serializableObject = null;

            switch (serializedFormat)
            {
                case SerializedFormat.Binary:
                    serializableObject = LoadFromBinaryFormat(path, null);
                    break;

                case SerializedFormat.Document:
                default:
                    serializableObject = LoadFromDocumentFormat(null, path, null);
                    break;
            }

            Logger.Trace($"Completed Load() - path: {path}, serializedFormat: {serializedFormat}");
            return serializableObject;
        }

        /// <summary>
        /// Loads an object from an XML file in Document format, supplying extra data types to enable deserialization of custom
        ///     types within the object.
        /// </summary>
        /// <example>
        /// <code>
        /// serializableObject = ObjectXMLSerializer&lt;SerializableObject&gt;.Load(@"C:\XMLObjects.xml", new Type[] { typeof(MyCustomType) });
        /// </code>
        /// </example>
        /// <param name="path">
        /// Path of the file to load the object from.
        /// </param>
        /// <param name="extraTypes">
        /// Extra data types to enable deserialization of custom types within the object.
        /// </param>
        /// <returns>
        /// Object loaded from an XML file in Document format.
        /// </returns>
        public static T Load(string path, Type[] extraTypes)
        {
            Logger.Trace($"Started Load() - path: {path}, extraTypes: {extraTypes}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("Path may not be empty");
                throw new ArgumentException("Path may not be empty");
            }

            T serializableObject = LoadFromDocumentFormat(extraTypes, path, null);

            Logger.Trace($"Completed Load() - path: {path}, extraTypes: {extraTypes}");
            return serializableObject;
        }

        /// <summary>
        /// Loads an object from an XML file in Document format, located in a specified isolated storage area.
        /// </summary>
        /// <example>
        /// <code>
        /// serializableObject = ObjectXMLSerializer&lt;SerializableObject&gt;.Load("XMLObjects.xml", IsolatedStorageFile.GetUserStoreForAssembly());
        /// </code>
        /// </example>
        /// <param name="fileName">
        /// Name of the file in the isolated storage area to load the object from.
        /// </param>
        /// <param name="isolatedStorageDirectory">
        /// Isolated storage area directory containing the XML file to load the object from.
        /// </param>
        /// <returns>
        /// Object loaded from an XML file in Document format located in a specified isolated storage area.
        /// </returns>
        public static T Load(string fileName, IsolatedStorageFile isolatedStorageDirectory)
        {
            Logger.Trace(
                $"Started Load() - fileName: {fileName}, isolatedStorageDirectory: {isolatedStorageDirectory.ToString()}");

            if (string.IsNullOrEmpty(fileName))
            {
                Logger.Error("fileName may not be empty");
                throw new ArgumentException("fileName may not be empty");
            }

            if (isolatedStorageDirectory == null)
            {
                Logger.Error("isolatedStorageDirectory may not be null");
                throw new ArgumentException("isolatedStorageDirectory may not be null");
            }

            T serializableObject = LoadFromDocumentFormat(null, fileName, isolatedStorageDirectory);

            Logger.Trace(
                $"Completed Load() - fileName: {fileName}, isolatedStorageDirectory: {isolatedStorageDirectory.ToString()}");
            return serializableObject;
        }

        /// <summary>
        /// Loads an object from an XML file located in a specified isolated storage area, using a specified serialized format.
        /// </summary>
        /// <example>
        /// <code>
        /// serializableObject = ObjectXMLSerializer&lt;SerializableObject&gt;.Load("XMLObjects.xml", IsolatedStorageFile.GetUserStoreForAssembly(), SerializedFormat.Binary);
        /// </code>
        /// </example>
        /// <param name="fileName">
        /// Name of the file in the isolated storage area to load the object from.
        /// </param>
        /// <param name="isolatedStorageDirectory">
        /// Isolated storage area directory containing the XML file to load the object from.
        /// </param>
        /// <param name="serializedFormat">
        /// XML serialized format used to load the object.
        /// </param>
        /// <returns>
        /// Object loaded from an XML file located in a specified isolated storage area, using a specified serialized
        ///     format.
        /// </returns>
        public static T Load(
            string fileName,
            IsolatedStorageFile isolatedStorageDirectory,
            SerializedFormat serializedFormat)
        {
            Logger.Trace(
                $"Started Load() - fileName: {fileName}, isolatedStorageDirectory: {isolatedStorageDirectory.ToString()}, serializedFormat: {serializedFormat.ToString()}");

            if (string.IsNullOrEmpty(fileName))
            {
                Logger.Error("fileName may not be empty");
                throw new ArgumentException("fileName may not be empty");
            }

            if (isolatedStorageDirectory == null)
            {
                Logger.Error("isolatedStorageDirectory may not be null");
                throw new ArgumentException("isolatedStorageDirectory may not be null");
            }

            T serializableObject = null;

            switch (serializedFormat)
            {
                case SerializedFormat.Binary:
                    serializableObject = LoadFromBinaryFormat(fileName, isolatedStorageDirectory);
                    break;

                case SerializedFormat.Document:
                default:
                    serializableObject = LoadFromDocumentFormat(null, fileName, isolatedStorageDirectory);
                    break;
            }

            Logger.Trace(
                $"Completed Load() - fileName: {fileName}, isolatedStorageDirectory: {isolatedStorageDirectory.ToString()}, serializedFormat: {serializedFormat.ToString()}");
            return serializableObject;
        }

        /// <summary>
        /// Loads an object from an XML file in Document format, located in a specified isolated storage area, and supplying
        ///     extra data types to enable deserialization of custom types within the object.
        /// </summary>
        /// <example>
        /// <code>
        /// serializableObject = ObjectXMLSerializer&lt;SerializableObject&gt;.Load("XMLObjects.xml", IsolatedStorageFile.GetUserStoreForAssembly(), new Type[] { typeof(MyCustomType) });
        /// </code>
        /// </example>
        /// <param name="fileName">
        /// Name of the file in the isolated storage area to load the object from.
        /// </param>
        /// <param name="isolatedStorageDirectory">
        /// Isolated storage area directory containing the XML file to load the object from.
        /// </param>
        /// <param name="extraTypes">
        /// Extra data types to enable deserialization of custom types within the object.
        /// </param>
        /// <returns>
        /// Object loaded from an XML file located in a specified isolated storage area, using a specified serialized
        ///     format.
        /// </returns>
        public static T Load(string fileName, IsolatedStorageFile isolatedStorageDirectory, Type[] extraTypes)
        {
            Logger.Trace(
                $"Started Load() - fileName: {fileName}, isolatedStorageDirectory: {isolatedStorageDirectory.ToString()}, serializedFormat: {extraTypes}");

            if (string.IsNullOrEmpty(fileName))
            {
                Logger.Error("fileName may not be empty");
                throw new ArgumentException("fileName may not be empty");
            }

            if (isolatedStorageDirectory == null)
            {
                Logger.Error("isolatedStorageDirectory may not be null");
                throw new ArgumentException("isolatedStorageDirectory may not be null");
            }

            T serializableObject = LoadFromDocumentFormat(null, fileName, isolatedStorageDirectory);

            Logger.Trace(
                $"Completed Load() - fileName: {fileName}, isolatedStorageDirectory: {isolatedStorageDirectory.ToString()}, serializedFormat: {extraTypes}");
            return serializableObject;
        }

        /// <summary>
        /// Saves an object to an XML file in Document format.
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// SerializableObject serializableObject = new SerializableObject();
        /// 
        /// ObjectXMLSerializer&lt;SerializableObject&gt;.Save(serializableObject, @"C:\XMLObjects.xml");
        /// </code>
        /// </example>
        /// <param name="serializableObject">
        /// Serializable object to be saved to file.
        /// </param>
        /// <param name="path">
        /// Path of the file to save the object to.
        /// </param>
        public static void Save(T serializableObject, string path)
        {
            Logger.Trace($"Started Save() - path: {path},  serializableObject: {serializableObject.ToString()}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("path may not be empty");
                throw new ArgumentException("path may not be empty");
            }

            SaveToDocumentFormat(serializableObject, null, path, null);

            Logger.Trace($"Completed Save() - path: {path},  serializableObject: {serializableObject.ToString()}");
        }

        /// <summary>
        /// Saves an object to an XML file using a specified serialized format.
        /// </summary>
        /// <example>
        /// <code>
        /// SerializableObject serializableObject = new SerializableObject();
        /// 
        /// ObjectXMLSerializer&lt;SerializableObject&gt;.Save(serializableObject, @"C:\XMLObjects.xml", SerializedFormat.Binary);
        /// </code>
        /// </example>
        /// <param name="serializableObject">
        /// Serializable object to be saved to file.
        /// </param>
        /// <param name="path">
        /// Path of the file to save the object to.
        /// </param>
        /// <param name="serializedFormat">
        /// XML serialized format used to save the object.
        /// </param>
        public static void Save(T serializableObject, string path, SerializedFormat serializedFormat)
        {
            Logger.Trace($"Started Save() - path: {path},  serializableObject: {serializableObject.ToString()}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("path may not be empty");
                throw new ArgumentException("path may not be empty");
            }

            switch (serializedFormat)
            {
                case SerializedFormat.Binary:
                    SaveToBinaryFormat(serializableObject, path, null);
                    break;

                case SerializedFormat.Document:
                default:
                    SaveToDocumentFormat(serializableObject, null, path, null);
                    break;
            }

            Logger.Trace($"Completed Save() - path: {path},  serializableObject: {serializableObject.ToString()}");
        }

        /// <summary>
        /// Saves an object to an XML file in Document format, supplying extra data types to enable serialization of custom
        ///     types within the object.
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// SerializableObject serializableObject = new SerializableObject();
        /// 
        /// ObjectXMLSerializer&lt;SerializableObject&gt;.Save(serializableObject, @"C:\XMLObjects.xml", new Type[] { typeof(MyCustomType) });
        /// </code>
        /// </example>
        /// <param name="serializableObject">
        /// Serializable object to be saved to file.
        /// </param>
        /// <param name="path">
        /// Path of the file to save the object to.
        /// </param>
        /// <param name="extraTypes">
        /// Extra data types to enable serialization of custom types within the object.
        /// </param>
        public static void Save(T serializableObject, string path, Type[] extraTypes)
        {
            Logger.Trace(
                $"Started Save() - fileName: {path},  serializableObject: {serializableObject.ToString()}, extraType {extraTypes}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("path may not be empty");
                throw new ArgumentException("path may not be empty");
            }

            SaveToDocumentFormat(serializableObject, extraTypes, path, null);

            Logger.Trace(
                $"Completed Save() - fileName: {path},  serializableObject: {serializableObject.ToString()}, extraType {extraTypes}");
        }

        /// <summary>
        /// Saves an object to an XML file in Document format, located in a specified isolated storage area.
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// SerializableObject serializableObject = new SerializableObject();
        /// 
        /// ObjectXMLSerializer&lt;SerializableObject&gt;.Save(serializableObject, "XMLObjects.xml", IsolatedStorageFile.GetUserStoreForAssembly());
        /// </code>
        /// </example>
        /// <param name="serializableObject">
        /// Serializable object to be saved to file.
        /// </param>
        /// <param name="fileName">
        /// Name of the file in the isolated storage area to save the object to.
        /// </param>
        /// <param name="isolatedStorageDirectory">
        /// Isolated storage area directory containing the XML file to save the object to.
        /// </param>
        public static void Save(T serializableObject, string fileName, IsolatedStorageFile isolatedStorageDirectory)
        {
            Logger.Trace(
                $"Started Save() - fileName: {fileName},  serializableObject: {serializableObject.ToString()}, isolatedStorageDirectory {isolatedStorageDirectory.ToString()}");

            if (string.IsNullOrEmpty(fileName))
            {
                Logger.Error("path may not be empty");
                throw new ArgumentException("path may not be empty");
            }

            SaveToDocumentFormat(serializableObject, null, fileName, isolatedStorageDirectory);

            Logger.Trace(
                $"Started Save() - fileName: {fileName},  serializableObject: {serializableObject.ToString()}, isolatedStorageDirectory {isolatedStorageDirectory.ToString()}");
        }

        /// <summary>
        /// Saves an object to an XML file located in a specified isolated storage area, using a specified serialized format.
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// SerializableObject serializableObject = new SerializableObject();
        /// 
        /// ObjectXMLSerializer&lt;SerializableObject&gt;.Save(serializableObject, "XMLObjects.xml", IsolatedStorageFile.GetUserStoreForAssembly(), SerializedFormat.Binary);
        /// </code>
        /// </example>
        /// <param name="serializableObject">
        /// Serializable object to be saved to file.
        /// </param>
        /// <param name="fileName">
        /// Name of the file in the isolated storage area to save the object to.
        /// </param>
        /// <param name="isolatedStorageDirectory">
        /// Isolated storage area directory containing the XML file to save the object to.
        /// </param>
        /// <param name="serializedFormat">
        /// XML serialized format used to save the object.
        /// </param>
        public static void Save(
            T serializableObject,
            string fileName,
            IsolatedStorageFile isolatedStorageDirectory,
            SerializedFormat serializedFormat)
        {
            Logger.Trace(
                $"Started Save() - fileName: {fileName},  serializableObject: {serializableObject.ToString()}, isolatedStorageDirectory {isolatedStorageDirectory.ToString()}, serializedFormat : {serializedFormat}");

            if (string.IsNullOrEmpty(fileName))
            {
                Logger.Error("path may not be empty");
                throw new ArgumentException("path may not be empty");
            }

            switch (serializedFormat)
            {
                case SerializedFormat.Binary:
                    SaveToBinaryFormat(serializableObject, fileName, isolatedStorageDirectory);
                    break;

                case SerializedFormat.Document:
                default:
                    SaveToDocumentFormat(serializableObject, null, fileName, isolatedStorageDirectory);
                    break;
            }

            Logger.Trace(
                $"Completed Save() - fileName: {fileName},  serializableObject: {serializableObject.ToString()}, isolatedStorageDirectory {isolatedStorageDirectory.ToString()}, serializedFormat : {serializedFormat}");
        }

        /// <summary>
        /// Saves an object to an XML file in Document format, located in a specified isolated storage area, and supplying
        ///     extra data types to enable serialization of custom types within the object.
        /// </summary>
        /// <example>
        /// <code>
        /// SerializableObject serializableObject = new SerializableObject();
        /// 
        /// ObjectXMLSerializer&lt;SerializableObject&gt;.Save(serializableObject, "XMLObjects.xml", IsolatedStorageFile.GetUserStoreForAssembly(), new Type[] { typeof(MyCustomType) });
        /// </code>
        /// </example>
        /// <param name="serializableObject">
        /// Serializable object to be saved to file.
        /// </param>
        /// <param name="fileName">
        /// Name of the file in the isolated storage area to save the object to.
        /// </param>
        /// <param name="isolatedStorageDirectory">
        /// Isolated storage area directory containing the XML file to save the object to.
        /// </param>
        /// <param name="extraTypes">
        /// Extra data types to enable serialization of custom types within the object.
        /// </param>
        public static void Save(
            T serializableObject,
            string fileName,
            IsolatedStorageFile isolatedStorageDirectory,
            Type[] extraTypes)
        {
            Logger.Trace(
                $"Started Save() - fileName: {fileName},  serializableObject: {serializableObject.ToString()}, isolatedStorageDirectory {isolatedStorageDirectory.ToString()}, extraTypes : {extraTypes}");

            if (string.IsNullOrEmpty(fileName))
            {
                Logger.Error("path may not be empty");
                throw new ArgumentException("path may not be empty");
            }

            SaveToDocumentFormat(serializableObject, null, fileName, isolatedStorageDirectory);

            Logger.Trace(
                $"Completed Save() - fileName: {fileName},  serializableObject: {serializableObject.ToString()}, isolatedStorageDirectory {isolatedStorageDirectory.ToString()}, extraTypes : {extraTypes}");
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The create file stream.
        /// </summary>
        /// <param name="isolatedStorageFolder">
        /// The isolated storage folder.
        /// </param>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <returns>
        /// The <see cref="FileStream"/>.
        /// </returns>
        private static FileStream CreateFileStream(IsolatedStorageFile isolatedStorageFolder, string path)
        {
            Logger.Trace($"Started CreateFileStream() - path: {path}, isolatedStorageDirectory {isolatedStorageFolder}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("path may not be empty");
                throw new ArgumentException("path may not be empty");
            }

            FileStream fileStream = null;

            if (isolatedStorageFolder == null)
            {
                fileStream = new FileStream(path, FileMode.OpenOrCreate);
            }
            else
            {
                fileStream = new IsolatedStorageFileStream(path, FileMode.OpenOrCreate, isolatedStorageFolder);
            }

            Logger.Trace(
                $"Completed CreateFileStream() - path: {path}, isolatedStorageDirectory {isolatedStorageFolder}");
            return fileStream;
        }

        /// <summary>
        /// The create text reader.
        /// </summary>
        /// <param name="isolatedStorageFolder">
        /// The isolated storage folder.
        /// </param>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <returns>
        /// The <see cref="TextReader"/>.
        /// </returns>
        private static TextReader CreateTextReader(IsolatedStorageFile isolatedStorageFolder, string path)
        {
            Logger.Trace($"Started CreateTextReader() - path: {path}, isolatedStorageDirectory {isolatedStorageFolder}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("path may not be empty");
                throw new ArgumentException("path may not be empty");
            }

            TextReader textReader = null;

            if (isolatedStorageFolder == null)
            {
                textReader = new StreamReader(path);
            }
            else
            {
                textReader = new StreamReader(new IsolatedStorageFileStream(path, FileMode.Open, isolatedStorageFolder));
            }

            Logger.Trace(
                $"Completed CreateTextReader() - path: {path}, isolatedStorageDirectory {isolatedStorageFolder}");
            return textReader;
        }

        /// <summary>
        /// The create text writer.
        /// </summary>
        /// <param name="isolatedStorageFolder">
        /// The isolated storage folder.
        /// </param>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <returns>
        /// The <see cref="TextWriter"/>.
        /// </returns>
        private static TextWriter CreateTextWriter(IsolatedStorageFile isolatedStorageFolder, string path)
        {
            Logger.Trace($"Started CreateTextWriter() - path: {path}, isolatedStorageDirectory {isolatedStorageFolder}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("path may not be empty");
                throw new ArgumentException("path may not be empty");
            }

            TextWriter textWriter = null;

            if (isolatedStorageFolder == null)
            {
                textWriter = new StreamWriter(path);
            }
            else
            {
                textWriter =
                    new StreamWriter(new IsolatedStorageFileStream(path, FileMode.OpenOrCreate, isolatedStorageFolder));
            }

            Logger.Trace(
                $"Completed CreateTextWriter() - path: {path}, isolatedStorageDirectory {isolatedStorageFolder}");
            return textWriter;
        }

        /// <summary>
        /// The create xml serializer.
        /// </summary>
        /// <param name="extraTypes">
        /// The extra types.
        /// </param>
        /// <returns>
        /// The <see cref="XmlSerializer"/>.
        /// </returns>
        private static XmlSerializer CreateXmlSerializer(Type[] extraTypes)
        {
            Logger.Trace($"Started CreateXmlSerializer() - extraTypes: {extraTypes}");

            Type objectType = typeof(T);

            XmlSerializer xmlSerializer = null;

            if (extraTypes != null)
            {
                xmlSerializer = new XmlSerializer(objectType, extraTypes);
            }
            else
            {
                xmlSerializer = new XmlSerializer(objectType);
            }

            Logger.Trace($"Completed CreateXmlSerializer() - extraTypes: {extraTypes}");
            return xmlSerializer;
        }

        /// <summary>
        /// The load from binary format.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <param name="isolatedStorageFolder">
        /// The isolated storage folder.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        private static T LoadFromBinaryFormat(string path, IsolatedStorageFile isolatedStorageFolder)
        {
            Logger.Trace(
                $"Started LoadFromBinaryFormat() - path: {path}, isolatedStorageFolder: {isolatedStorageFolder}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("Path may not be empty");
                throw new ArgumentException("Path may not be empty");
            }

            T serializableObject = null;

            using (FileStream fileStream = CreateFileStream(isolatedStorageFolder, path))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                serializableObject = binaryFormatter.Deserialize(fileStream) as T;
            }

            Logger.Trace(
                $"Completed LoadFromBinaryFormat() - path: {path}, isolatedStorageFolder: {isolatedStorageFolder}");
            return serializableObject;
        }

        /// <summary>
        /// The load from document format.
        /// </summary>
        /// <param name="extraTypes">
        /// The extra types.
        /// </param>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <param name="isolatedStorageFolder">
        /// The isolated storage folder.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        private static T LoadFromDocumentFormat(
            Type[] extraTypes,
            string path,
            IsolatedStorageFile isolatedStorageFolder)
        {
            Logger.Trace(
                $"Started LoadFromDocumentFormat() - path: {path}, isolatedStorageFolder: {isolatedStorageFolder}, extraTypes: {extraTypes}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("Path may not be empty");
                throw new ArgumentException("Path may not be empty");
            }

            T serializableObject = null;

            using (TextReader textReader = CreateTextReader(isolatedStorageFolder, path))
            {
                XmlSerializer xmlSerializer = CreateXmlSerializer(extraTypes);
                serializableObject = xmlSerializer.Deserialize(textReader) as T;
            }

            Logger.Trace(
                $"Completed LoadFromDocumentFormat() - path: {path}, isolatedStorageFolder: {isolatedStorageFolder}, extraTypes: {extraTypes}");
            return serializableObject;
        }

        /// <summary>
        /// The save to binary format.
        /// </summary>
        /// <param name="serializableObject">
        /// The serializable object.
        /// </param>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <param name="isolatedStorageFolder">
        /// The isolated storage folder.
        /// </param>
        private static void SaveToBinaryFormat(
            T serializableObject,
            string path,
            IsolatedStorageFile isolatedStorageFolder)
        {
            Logger.Trace($"Started SaveToBinaryFormat() - path: {path}, isolatedStorageFolder: {isolatedStorageFolder}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("Path may not be empty");
                throw new ArgumentException("Path may not be empty");
            }

            using (FileStream fileStream = CreateFileStream(isolatedStorageFolder, path))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, serializableObject);
            }

            Logger.Trace(
                $"Completed SaveToBinaryFormat() - path: {path}, isolatedStorageFolder: {isolatedStorageFolder}");
        }

        /// <summary>
        /// The save to document format.
        /// </summary>
        /// <param name="serializableObject">
        /// The serializable object.
        /// </param>
        /// <param name="extraTypes">
        /// The extra types.
        /// </param>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <param name="isolatedStorageFolder">
        /// The isolated storage folder.
        /// </param>
        private static void SaveToDocumentFormat(
            T serializableObject,
            Type[] extraTypes,
            string path,
            IsolatedStorageFile isolatedStorageFolder)
        {
            Logger.Trace(
                $"Started SaveToBinaryFormat() - path: {path}, isolatedStorageFolder: {isolatedStorageFolder}, extraTypes: {extraTypes}");

            if (string.IsNullOrEmpty(path))
            {
                Logger.Error("Path may not be empty");
                throw new ArgumentException("Path may not be empty");
            }

            using (TextWriter textWriter = CreateTextWriter(isolatedStorageFolder, path))
            {
                XmlSerializer xmlSerializer = CreateXmlSerializer(extraTypes);
                xmlSerializer.Serialize(textWriter, serializableObject);
            }

            Logger.Trace(
                $"Completed SaveToBinaryFormat() - path: {path}, isolatedStorageFolder: {isolatedStorageFolder}, extraTypes: {extraTypes}");
        }

        #endregion

        // Specify that T must be a class.
    }
}