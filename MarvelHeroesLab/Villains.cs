using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarvelHeroesLabLibrary;

namespace MarvelHeroesLab
{
    public partial class Villains : Form
    {
        public Villains()
        {
            InitializeComponent();
            villainBindingSource.DataSource = Villain.GetAllVillians();
        }
    }
}
