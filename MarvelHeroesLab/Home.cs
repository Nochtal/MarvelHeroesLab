using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarvelHeroesLab
{
    ///  Welcome to Marvel Heroes Lab!
    ///     By Brendan CMG and Nochtal B
    ///  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///  For use with the Debugging and Troubleshooting Workshop
    ///  April 29th, 2016, at 2:00 pm
    ///  Renton Technical College, hosted by CHIPS
    ///     3000 NE 4th Street
    ///     C-102
    ///     Renton, WA 98056
    ///   chips@student.rtc.edu
    
    public partial class Home : Form
    {
        #region LOAD
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region VARIABLES
        SuperHeroes frmSuperHeroes = new SuperHeroes();
        ShieldAgents frmShieldAgents = new ShieldAgents();
        Villains frmVillains = new Villains();
        #endregion
        #region PUBLIC METHODS
        
        #endregion
        #region PRIVATE METHODS

        #endregion
        #region EVENTS
        private void btnOpenHeroes_Click(object sender, EventArgs e)
        {
            // Button to open the form for Super Heroes
            // Determine if form is already created or not.
            if (frmSuperHeroes != null) frmSuperHeroes.Show();
            else // If doesn't already exist, create a new one.
            {
                frmSuperHeroes = new SuperHeroes();
                frmSuperHeroes.Show();
            }
        }

        private void btnOpenShieldAgents_Click(object sender, EventArgs e)
        {
            // Button to open the form for SHIELD Agents
            // Determine if form is already created or not.
            if (frmShieldAgents != null) frmShieldAgents.Show();
            else // If doesn't already exist, create a new one.
            {
                frmShieldAgents = new ShieldAgents();
                frmShieldAgents.Show();
            }
        }

        private void btnOpenVillains_Click(object sender, EventArgs e)
        {
            // Button to open the form for Villains
            if (frmVillains != null) frmVillains.Show();
            else // If doesn't already exist, create a new one.
            {
                frmVillains = new Villains();
                frmVillains.Show();
            }
        }
        #endregion
    }
}