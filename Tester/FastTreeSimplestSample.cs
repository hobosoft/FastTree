﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tester.DataModel;

namespace Tester
{
    public partial class FastTreeSimplestSample : Form
    {
        private Node root;

        public FastTreeSimplestSample()
        {
            InitializeComponent();

            CreateTree();
            ft.Build(root);
        }

        private void CreateTree()
        {
            root = new Node("Root");
            for (int i = 0; i < 1000; i++)
            {
                var n = new Node("Node " + i);
                root.Childs.Add(n);
                for (int j = 0; j < 10; j++)
                {
                    var subNode = new Node("SubNode " + i + "-" + j);
                    n.Childs.Add(subNode);
                    for (int k = 0; k < 10; k++)
                    {
                        var subSubNode = new Node("SubNode " + i + "-" + j + "-" + k);
                        subNode.Childs.Add(subSubNode);
                    }
                }
            }
        }

        #region Routines

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            (propertyGrid1.SelectedObject as Control).Invalidate();
        }

        #endregion
    }
}