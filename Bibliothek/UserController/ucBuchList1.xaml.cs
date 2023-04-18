﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bibliothek.UserController
{
    /// <summary>
    /// Interaktionslogik für ucBuchList1.xaml
    /// </summary>
    public partial class ucBuchList1 : UserControl
    {
        public List<Buch> Buchlist;
        public ucBuchList1()
        {
            InitializeComponent();

            using (DbCont _context=new DbCont())
            {
                Buchlist = _context.Buches.ToList();
            }
            grid_buch.ItemsSource= Buchlist;
        }

       
    }
}
