using Common.Logging;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.Common.Contract.UI;
using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
using DotNetScaffolder.Core.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources
{
    public class AdoSourceUi : IDataSourceUI
    {
        public TextBox TxtConnection { get; set; }
        public ListView ListViewDrivers { get; set; }

        public AdoSourceUi(TextBox textBox, ListView listViewDrivers)
        {
            this.TxtConnection = textBox;
            this.ListViewDrivers = listViewDrivers;
            this.Options = new AdoSourceOptions();
        }

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        /// <summary>
        /// The options.
        /// </summary>
        public AdoSourceOptions Options { get; set; }

        /// <summary>
        ///     Gets or sets the parameters.
        /// </summary>
        public object Parameters { get; set; }

        /// <summary>
        /// Gets or sets the source type.
        /// </summary>
        public ISourceType SourceType { get; set; }

        /// <summary>
        /// Gets or sets the validation result.
        /// </summary>
        public List<Validation> ValidationResult { get; set; }

        /// <summary>
        /// The load data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void LoadData(object parameters)
        {
            Logger.Trace("Started LoadData()");

            this.Options = this.SourceType.Load(parameters) as AdoSourceOptions;

            if (this.Options != null)
            {
                this.TxtConnection.Text = this.Options.ConnectionString;

                this.TestData(this.Options, false);
            }
            else
            {
                this.TxtConnection.Text = string.Empty;
            }

            Logger.Trace("Completed LoadData()");
        }

        /// <inheritdoc />
        /// <summary>
        ///     The save data.
        /// </summary>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public void SaveData(object parameters)
        {
            Logger.Trace("Started SaveData()");
            List<object> saveParameters = new List<object> { parameters, this.Options };
            this.Options.Schemas.Clear();
            this.Options.Schemas.AddRange(this.ReturnSelectedSchemas());
            this.SourceType.Save(saveParameters);

            Logger.Trace("Completed SaveData()");
        }

        /// <summary>
        /// The test data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void TestData(object parameters, bool displayMessageOnSucceed)
        {
            Logger.Trace("Started TestData()");

            if (this.SourceType.Test(this.Options))
            {
                if (displayMessageOnSucceed)
                {
                    MessageBox.Show("Connected to Sql Server", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.SourceType.ReturnSchemas(this.Options);
                this.ListViewDrivers.Items.AddRange(this.ReturnSchemasSchemaListViewItems().ToArray());

                foreach (var schema in this.Options.Schemas)
                {
                    ListViewItem item = this.ListViewDrivers.FindItemWithText(schema);
                    //items = this.ListViewDrivers.Items.Find(schema, false);

                    if (item != null)
                    {
                        item.Checked = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Unable to Connect to Sql Server", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Logger.Trace("Completed TestData()");
        }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validation()");

            List<Validation> result = new List<Validation>();

            return result;
        }

        /// <summary>
        ///     The return driver types.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        private ListViewItem[] ReturnSchemasSchemaListViewItems()
        {
            var items = new List<ListViewItem>();
            ListViewItem item;

            foreach (var schema in this.SourceType.Schemas)
            {
                items.Add(new ListViewItem { Text = schema, Tag = schema });
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

        private List<string> ReturnSelectedSchemas()
        {
            List<string> result = new List<string>();

            foreach (ListViewItem schema in this.ListViewDrivers.Items)
            {
                if (schema.Checked)
                {
                    result.Add(schema.Text);
                }
            }

            return result;
        }
    }
}
