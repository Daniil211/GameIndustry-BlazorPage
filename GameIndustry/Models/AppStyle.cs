namespace GameIndustry.Models
{
    public class AppStyle
    {
        public string Color { get; set; } = "green";

        public string Size { get; set; } = "65px";

        public List<string> WitcherWords { get; set; } = new List<string>()
        {
            new string("AAAAAAAAA AAAAAAA AAAAAAAAAA AAAAAAAAAAAAA AAAAAAAAAA AAAAAAA(Witcher)"),
            new string("BBBBB BBBB BBBBB    BBB BB B(Witcher)"),
            new string("CCCCCC CCCCCCCC C CCCC CCCCCCCCCCC CCCCCCCC(Witcher)")
        };

        public List<TableListModel> TableStyle { get; set; } = new List<TableListModel>()
        {
            new TableListModel(){Text = "Table Dark", Value="table-dark"},
            new TableListModel(){Text = "Table Striped", Value="table-striped"},
            new TableListModel(){Text = "Table Bordered", Value="table-bordered"}
        };
    }
}
