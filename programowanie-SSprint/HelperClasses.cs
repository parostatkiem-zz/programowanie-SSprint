using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programowanie_SSprint
{
    static class VisualHelper
    {
        public static void RefreshTshirtList(TreeView theTreeView, List<tshirt> theList)
        {
            theTreeView.Nodes.Clear();
            TreeNode tmp;
            TreeNode currentParentNode;


            foreach (tshirt t in theList)
            {
                //firma
                tmp = new TreeNode(t.company.name);
                tmp.Name = t.company.name;
                if (!theTreeView.Nodes.ContainsKey(tmp.Name))
                {
                    //nie ma jeszcze takiej firmy
                    theTreeView.Nodes.Add(tmp);
                }
                currentParentNode = theTreeView.Nodes.Find(tmp.Name, false).First();


                //plec
                tmp = new TreeNode(t.sex);
                tmp.Name = t.sex;
                if (!currentParentNode.Nodes.ContainsKey(tmp.Name))
                {
                    //nie ma jeszcze takiej firmy
                    currentParentNode.Nodes.Add(tmp);
                }
                currentParentNode = currentParentNode.Nodes.Find(tmp.Name, false).First();

                //styl
                tmp = new TreeNode(t.style.name);
                tmp.Name = t.style.name;
                if (!currentParentNode.Nodes.ContainsKey(tmp.Name))
                {
                    //nie ma jeszcze takiej firmy
                    currentParentNode.Nodes.Add(tmp);
                }
                currentParentNode = currentParentNode.Nodes.Find(tmp.Name, false).First();


                //konkretna koszulka
                tmp = new TreeNode(t.ToString());
                tmp.Tag = t;
                tmp.NodeFont = new Font(theTreeView.Font, FontStyle.Bold);

                currentParentNode.Nodes.Add(tmp);
            }


        }
    }
}
