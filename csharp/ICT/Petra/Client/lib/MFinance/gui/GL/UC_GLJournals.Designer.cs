// auto generated with nant generateWinforms from UC_GLJournals.yaml
//
// DO NOT edit manually, DO NOT edit with the designer
//
//
// DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
//
// @Authors:
//       auto generated
//
// Copyright 2004-2010 by OM International
//
// This file is part of OpenPetra.org.
//
// OpenPetra.org is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// OpenPetra.org is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with OpenPetra.org.  If not, see <http://www.gnu.org/licenses/>.
//
using System;
using System.Windows.Forms;
using Mono.Unix;
using Ict.Common.Controls;
using Ict.Petra.Client.CommonControls;

namespace Ict.Petra.Client.MFinance.Gui.GL
{
    partial class TUC_GLJournals
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TUC_GLJournals));

            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCurrentPeriod = new System.Windows.Forms.TextBox();
            this.lblCurrentPeriod = new System.Windows.Forms.Label();
            this.txtLedgerNumber = new System.Windows.Forms.TextBox();
            this.lblLedgerNumber = new System.Windows.Forms.Label();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.lblBatchNumber = new System.Windows.Forms.Label();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.lblDebit = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.lblControl = new System.Windows.Forms.Label();
            this.pnlDetailGrid = new System.Windows.Forms.Panel();
            this.grdDetails = new Ict.Common.Controls.TSgrdDataGridPaged();
            this.pnlDetailButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDetailJournalDescription = new System.Windows.Forms.TextBox();
            this.lblDetailJournalDescription = new System.Windows.Forms.Label();
            this.cmbDetailSubSystemCode = new Ict.Common.Controls.TCmbAutoComplete();
            this.lblDetailSubSystemCode = new System.Windows.Forms.Label();
            this.cmbDetailTransactionTypeCode = new Ict.Petra.Client.CommonControls.TCmbAutoPopulated();
            this.lblDetailTransactionTypeCode = new System.Windows.Forms.Label();
            this.cmbDetailTransactionCurrency = new Ict.Petra.Client.CommonControls.TCmbAutoPopulated();
            this.lblDetailTransactionCurrency = new System.Windows.Forms.Label();
            this.dtpDetailDateEffective = new Ict.Petra.Client.CommonControls.TtxtPetraDate();
            this.lblDetailDateEffective = new System.Windows.Forms.Label();
            this.txtDetailExchangeRateToBase = new System.Windows.Forms.TextBox();
            this.lblDetailExchangeRateToBase = new System.Windows.Forms.Label();

            this.pnlContent.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlDetailGrid.SuspendLayout();
            this.pnlDetailButtons.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();

            //
            // pnlContent
            //
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.AutoSize = true;
            this.pnlContent.Controls.Add(this.pnlDetailGrid);
            this.pnlContent.Controls.Add(this.pnlDetails);
            this.pnlContent.Controls.Add(this.pnlInfo);
            //
            // pnlInfo
            //
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.AutoSize = true;
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.AutoSize = true;
            this.pnlInfo.Controls.Add(this.tableLayoutPanel1);
            //
            // txtCurrentPeriod
            //
            this.txtCurrentPeriod.Location = new System.Drawing.Point(2,2);
            this.txtCurrentPeriod.Name = "txtCurrentPeriod";
            this.txtCurrentPeriod.Size = new System.Drawing.Size(150, 28);
            this.txtCurrentPeriod.ReadOnly = true;
            this.txtCurrentPeriod.TabStop = false;
            //
            // lblCurrentPeriod
            //
            this.lblCurrentPeriod.Location = new System.Drawing.Point(2,2);
            this.lblCurrentPeriod.Name = "lblCurrentPeriod";
            this.lblCurrentPeriod.AutoSize = true;
            this.lblCurrentPeriod.Text = "Current Period:";
            this.lblCurrentPeriod.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblCurrentPeriod.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCurrentPeriod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // txtLedgerNumber
            //
            this.txtLedgerNumber.Location = new System.Drawing.Point(2,2);
            this.txtLedgerNumber.Name = "txtLedgerNumber";
            this.txtLedgerNumber.Size = new System.Drawing.Size(150, 28);
            this.txtLedgerNumber.ReadOnly = true;
            this.txtLedgerNumber.TabStop = false;
            //
            // lblLedgerNumber
            //
            this.lblLedgerNumber.Location = new System.Drawing.Point(2,2);
            this.lblLedgerNumber.Name = "lblLedgerNumber";
            this.lblLedgerNumber.AutoSize = true;
            this.lblLedgerNumber.Text = "Ledger:";
            this.lblLedgerNumber.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblLedgerNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLedgerNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // txtBatchNumber
            //
            this.txtBatchNumber.Location = new System.Drawing.Point(2,2);
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.Size = new System.Drawing.Size(150, 28);
            this.txtBatchNumber.ReadOnly = true;
            this.txtBatchNumber.TabStop = false;
            //
            // lblBatchNumber
            //
            this.lblBatchNumber.Location = new System.Drawing.Point(2,2);
            this.lblBatchNumber.Name = "lblBatchNumber";
            this.lblBatchNumber.AutoSize = true;
            this.lblBatchNumber.Text = "Batch:";
            this.lblBatchNumber.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblBatchNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBatchNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // txtDebit
            //
            this.txtDebit.Location = new System.Drawing.Point(2,2);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(150, 28);
            this.txtDebit.ReadOnly = true;
            this.txtDebit.TabStop = false;
            //
            // lblDebit
            //
            this.lblDebit.Location = new System.Drawing.Point(2,2);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.AutoSize = true;
            this.lblDebit.Text = "Debit:";
            this.lblDebit.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblDebit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDebit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // txtCredit
            //
            this.txtCredit.Location = new System.Drawing.Point(2,2);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(150, 28);
            this.txtCredit.ReadOnly = true;
            this.txtCredit.TabStop = false;
            //
            // lblCredit
            //
            this.lblCredit.Location = new System.Drawing.Point(2,2);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.AutoSize = true;
            this.lblCredit.Text = "Credit:";
            this.lblCredit.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblCredit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // txtControl
            //
            this.txtControl.Location = new System.Drawing.Point(2,2);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(150, 28);
            this.txtControl.ReadOnly = true;
            this.txtControl.TabStop = false;
            //
            // lblControl
            //
            this.lblControl.Location = new System.Drawing.Point(2,2);
            this.lblControl.Name = "lblControl";
            this.lblControl.AutoSize = true;
            this.lblControl.Text = "Hash:";
            this.lblControl.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblControl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentPeriod, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLedgerNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDebit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCurrentPeriod, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLedgerNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDebit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBatchNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCredit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBatchNumber, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCredit, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblControl, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtControl, 5, 2);
            //
            // pnlDetailGrid
            //
            this.pnlDetailGrid.Name = "pnlDetailGrid";
            this.pnlDetailGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailGrid.AutoSize = true;
            this.pnlDetailGrid.Controls.Add(this.grdDetails);
            this.pnlDetailGrid.Controls.Add(this.pnlDetailButtons);
            //
            // grdDetails
            //
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetails.DoubleClick += new System.EventHandler(this.ShowTransactionTab);
            this.grdDetails.Selection.FocusRowEntered += new SourceGrid.RowEventHandler(this.FocusedRowChanged);
            //
            // pnlDetailButtons
            //
            this.pnlDetailButtons.Name = "pnlDetailButtons";
            this.pnlDetailButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetailButtons.AutoSize = true;
            //
            // tableLayoutPanel2
            //
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.AutoSize = true;
            this.pnlDetailButtons.Controls.Add(this.tableLayoutPanel2);
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(2,2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.AutoSize = true;
            this.btnAdd.Click += new System.EventHandler(this.NewRow);
            this.btnAdd.Text = "&Add";
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(2,2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.AutoSize = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelRow);
            this.btnCancel.Text = "&Cancel";
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 1);
            //
            // pnlDetails
            //
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetails.AutoSize = true;
            //
            // tableLayoutPanel3
            //
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.AutoSize = true;
            this.pnlDetails.Controls.Add(this.tableLayoutPanel3);
            //
            // txtDetailJournalDescription
            //
            this.txtDetailJournalDescription.Location = new System.Drawing.Point(2,2);
            this.txtDetailJournalDescription.Name = "txtDetailJournalDescription";
            this.txtDetailJournalDescription.Size = new System.Drawing.Size(350, 28);
            //
            // lblDetailJournalDescription
            //
            this.lblDetailJournalDescription.Location = new System.Drawing.Point(2,2);
            this.lblDetailJournalDescription.Name = "lblDetailJournalDescription";
            this.lblDetailJournalDescription.AutoSize = true;
            this.lblDetailJournalDescription.Text = "Journal Description:";
            this.lblDetailJournalDescription.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblDetailJournalDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDetailJournalDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // cmbDetailSubSystemCode
            //
            this.cmbDetailSubSystemCode.Location = new System.Drawing.Point(2,2);
            this.cmbDetailSubSystemCode.Name = "cmbDetailSubSystemCode";
            this.cmbDetailSubSystemCode.Size = new System.Drawing.Size(150, 28);
            this.cmbDetailSubSystemCode.Enabled = false;
            //
            // lblDetailSubSystemCode
            //
            this.lblDetailSubSystemCode.Location = new System.Drawing.Point(2,2);
            this.lblDetailSubSystemCode.Name = "lblDetailSubSystemCode";
            this.lblDetailSubSystemCode.AutoSize = true;
            this.lblDetailSubSystemCode.Text = "Sub System:";
            this.lblDetailSubSystemCode.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblDetailSubSystemCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDetailSubSystemCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // cmbDetailTransactionTypeCode
            //
            this.cmbDetailTransactionTypeCode.Location = new System.Drawing.Point(2,2);
            this.cmbDetailTransactionTypeCode.Name = "cmbDetailTransactionTypeCode";
            this.cmbDetailTransactionTypeCode.Size = new System.Drawing.Size(300, 28);
            this.cmbDetailTransactionTypeCode.ListTable = TCmbAutoPopulated.TListTableEnum.UserDefinedList;
            //
            // lblDetailTransactionTypeCode
            //
            this.lblDetailTransactionTypeCode.Location = new System.Drawing.Point(2,2);
            this.lblDetailTransactionTypeCode.Name = "lblDetailTransactionTypeCode";
            this.lblDetailTransactionTypeCode.AutoSize = true;
            this.lblDetailTransactionTypeCode.Text = "Transaction Type:";
            this.lblDetailTransactionTypeCode.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblDetailTransactionTypeCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDetailTransactionTypeCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // cmbDetailTransactionCurrency
            //
            this.cmbDetailTransactionCurrency.Location = new System.Drawing.Point(2,2);
            this.cmbDetailTransactionCurrency.Name = "cmbDetailTransactionCurrency";
            this.cmbDetailTransactionCurrency.Size = new System.Drawing.Size(300, 28);
            this.cmbDetailTransactionCurrency.ListTable = TCmbAutoPopulated.TListTableEnum.CurrencyCodeList;
            //
            // lblDetailTransactionCurrency
            //
            this.lblDetailTransactionCurrency.Location = new System.Drawing.Point(2,2);
            this.lblDetailTransactionCurrency.Name = "lblDetailTransactionCurrency";
            this.lblDetailTransactionCurrency.AutoSize = true;
            this.lblDetailTransactionCurrency.Text = "Currency:";
            this.lblDetailTransactionCurrency.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblDetailTransactionCurrency.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDetailTransactionCurrency.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // dtpDetailDateEffective
            //
            this.dtpDetailDateEffective.Location = new System.Drawing.Point(2,2);
            this.dtpDetailDateEffective.Name = "dtpDetailDateEffective";
            this.dtpDetailDateEffective.Size = new System.Drawing.Size(94, 28);
            this.dtpDetailDateEffective.Enabled = false;
            //
            // lblDetailDateEffective
            //
            this.lblDetailDateEffective.Location = new System.Drawing.Point(2,2);
            this.lblDetailDateEffective.Name = "lblDetailDateEffective";
            this.lblDetailDateEffective.AutoSize = true;
            this.lblDetailDateEffective.Text = "Effective Date:";
            this.lblDetailDateEffective.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblDetailDateEffective.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDetailDateEffective.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // txtDetailExchangeRateToBase
            //
            this.txtDetailExchangeRateToBase.Location = new System.Drawing.Point(2,2);
            this.txtDetailExchangeRateToBase.Name = "txtDetailExchangeRateToBase";
            this.txtDetailExchangeRateToBase.Size = new System.Drawing.Size(150, 28);
            //
            // lblDetailExchangeRateToBase
            //
            this.lblDetailExchangeRateToBase.Location = new System.Drawing.Point(2,2);
            this.lblDetailExchangeRateToBase.Name = "lblDetailExchangeRateToBase";
            this.lblDetailExchangeRateToBase.AutoSize = true;
            this.lblDetailExchangeRateToBase.Text = "Exchange Rate to Base:";
            this.lblDetailExchangeRateToBase.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblDetailExchangeRateToBase.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDetailExchangeRateToBase.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Controls.Add(this.lblDetailJournalDescription, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDetailSubSystemCode, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDetailTransactionTypeCode, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblDetailTransactionCurrency, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblDetailDateEffective, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblDetailExchangeRateToBase, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtDetailJournalDescription, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbDetailSubSystemCode, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbDetailTransactionTypeCode, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cmbDetailTransactionCurrency, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.dtpDetailDateEffective, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtDetailExchangeRateToBase, 1, 5);

            //
            // TUC_GLJournals
            //
            this.Font = new System.Drawing.Font("Verdana", 8.25f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(700, 500);

            this.Controls.Add(this.pnlContent);

            this.Name = "TUC_GLJournals";
            this.Text = "";

            this.tableLayoutPanel3.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlDetailButtons.ResumeLayout(false);
            this.pnlDetailGrid.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCurrentPeriod;
        private System.Windows.Forms.Label lblCurrentPeriod;
        private System.Windows.Forms.TextBox txtLedgerNumber;
        private System.Windows.Forms.Label lblLedgerNumber;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.Label lblBatchNumber;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.Panel pnlDetailGrid;
        private Ict.Common.Controls.TSgrdDataGridPaged grdDetails;
        private System.Windows.Forms.Panel pnlDetailButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtDetailJournalDescription;
        private System.Windows.Forms.Label lblDetailJournalDescription;
        private Ict.Common.Controls.TCmbAutoComplete cmbDetailSubSystemCode;
        private System.Windows.Forms.Label lblDetailSubSystemCode;
        private Ict.Petra.Client.CommonControls.TCmbAutoPopulated cmbDetailTransactionTypeCode;
        private System.Windows.Forms.Label lblDetailTransactionTypeCode;
        private Ict.Petra.Client.CommonControls.TCmbAutoPopulated cmbDetailTransactionCurrency;
        private System.Windows.Forms.Label lblDetailTransactionCurrency;
        private Ict.Petra.Client.CommonControls.TtxtPetraDate dtpDetailDateEffective;
        private System.Windows.Forms.Label lblDetailDateEffective;
        private System.Windows.Forms.TextBox txtDetailExchangeRateToBase;
        private System.Windows.Forms.Label lblDetailExchangeRateToBase;
    }
}
