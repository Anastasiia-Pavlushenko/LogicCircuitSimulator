using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicCircuitSimulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UnitTest.TestCase_LogicOperatorAnd();
            UnitTest.TestCase_LogicOperatorOr();
            UnitTest.TestCase_LogicOperatorXor();
            UnitTest.TestCase_LogicOperatorNot();

            UnitTest.TestCase_AndGateSimulation();
            UnitTest.TestCase_Nand_Nor_GatesSimulation();
            UnitTest.TestCase_Xnor_Xor_GatesSimulation();
            UnitTest.TestCase_Fork_3Not_And_GatesSimulation();

            UnitTest.TestCase_SetNumberOfInputPinsAnd();
            UnitTest.TestCase_6AndGateSimulation();

            UnitTest.TestCase_ConnectDisconnectOfNot();

            UnitTest.TestCase_SetNumberOfInputPinsNand();
            UnitTest.TestCase_8NandGateSimulation();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
