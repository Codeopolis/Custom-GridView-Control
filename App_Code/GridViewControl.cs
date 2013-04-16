using System.Web.UI.WebControls;

namespace CustomGridView
{
    /// <summary>
    /// Summary description for GridViewControl
    /// </summary>
    public class GridViewControl : CompositeControl
    {
        private GridView _gridView;
        private readonly TestDataList _list = new TestDataList();

        protected override void CreateChildControls()
        {
            //create new gridview object
            _gridView = new GridView
            {
                ID = string.Format("{0}_gridView", base.ID),
                AutoGenerateColumns = false
            };

            //Create Custom Field
            var customField = new TemplateField
            {
                HeaderTemplate = new SetTemplate(DataControlRowType.Header, "Name"),
                ItemTemplate = new SetTemplate(DataControlRowType.DataRow)
            };

            //Add custom field to gridview column
            _gridView.Columns.Add(customField);

            //Set test data list to datasource
            _gridView.DataSource = _list;

            //Bind gridview
            _gridView.DataBind();

            //Add gridview to composite control
            Controls.Add(_gridView);

        }
    }

}