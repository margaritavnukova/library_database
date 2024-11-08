using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryDB;

namespace ProjectDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string address; //= "(localdb)\\MSSQLLocalDB";
        string DBname = "Внукова_Курсач";
        string username; //= "LAPTOP-M9OPMFP6\\Vitra";
        string tableName = "Печатное_издание";
        string password = "";

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitForm initForm = new InitForm();
            initForm.ShowDialog();

            address = initForm.address;
            username = initForm.username;
            password = initForm.password;

            LoadDB();
        }

        private void LoadDB()
        {
            FormOutput fo = new FormOutput(address, DBname, username, password);

            fo.OutputAllToDg(DBname, tableName, BookDG);
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender == AddCatalogMenuItem)       AddCatalog();
            if (sender == EditCatalogMenuItem)      EditCatalog();
            if (sender == DeleteCatalogMenuItem)    DeleteCatalog();
        }

        void AddCatalog()
        {

        }

        void EditCatalog()
        {

        }

        void DeleteCatalog()
        {

        }
    }
}
