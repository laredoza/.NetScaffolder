// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectXMLSerializerUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Core.Common
{
    #region Usings

    using System.Collections.Generic;

    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Project;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The object xml serializer unit test.
    ///     Tests both document and binary serialization
    /// </summary>
    [TestClass]
    public class ObjectXMLSerializerUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        ///     Tests the Binary serialized format
        /// </summary>
        [TestMethod]
        public void ObjectXMLSerializerUnitTest_TestBinarySerializedFormat()
        {
            Save(SerializedFormat.Binary, "CollectionTest.dat");
            TestLoadedCollection("CollectionTest.dat", SerializedFormat.Binary);
        }

        /// <summary>
        ///     Tests the document serialized format
        /// </summary>
        [TestMethod]
        public void ObjectXMLSerializerUnitTest_TestDocumentSerializedFormat()
        {
            Save(SerializedFormat.Document, "CollectionTest.xml");
            TestLoadedCollection("CollectionTest.xml", SerializedFormat.Document);
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// Saves a collection
        /// </summary>
        /// <param name="format">
        /// The format.
        /// </param>
        /// <param name="path">
        /// The path.
        /// </param>
        private static void Save(SerializedFormat format, string path)
        {
            List<CollectionOption> collection = new List<CollectionOption>();
            collection.Add(new CollectionOption { Name = "NameA", NameSpace = "NameSpaceA" });
            collection.Add(new CollectionOption { Name = "NameB", NameSpace = "NameSpaceB" });
            ObjectXMLSerializer<List<CollectionOption>>.Save(collection, path, format);
        }

        /// <summary>
        /// Tests a loaded collection.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="format">
        /// The format.
        /// </param>
        private static void TestLoadedCollection(string name, SerializedFormat format)
        {
            List<CollectionOption> collection = ObjectXMLSerializer<List<CollectionOption>>.Load(name, format);

            Assert.IsNotNull(collection, "The Collection may not be empty");
            Assert.AreEqual(2, collection.Count, "There should be 2 items in the loaded collection");

            Assert.AreEqual("NameA", collection[0].Name, "The first collection item name should be NameA");
            Assert.AreEqual(
                "NameSpaceA",
                collection[0].NameSpace,
                "The first collection item Namespace should be NameSpaceA");

            Assert.AreEqual("NameB", collection[1].Name, "The first collection item name should be NameB");
            Assert.AreEqual(
                "NameSpaceB",
                collection[1].NameSpace,
                "The first collection item Namespace should be NameSpaceB");
        }

        #endregion
    }
}