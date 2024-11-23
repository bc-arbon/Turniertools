using System.Collections;

namespace SchochRechner.Logic
{
    public class ListViewColumnSorter : IComparer
    {
        private readonly CaseInsensitiveComparer objectCompare = new CaseInsensitiveComparer();

        public ListViewColumnSorter()
        {
            SortColumn = 0;
            Order = SortOrder.None;
        }

        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            compareResult = objectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);

            if (Order == SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (Order == SortOrder.Descending)
            {
                return -compareResult;
            }
            else
            {
                return 0;
            }
        }

        public int SortColumn { set; get; }

        public SortOrder Order { set; get; }
    }
}