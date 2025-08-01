using System.Windows.Forms;

namespace GradeApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblgradename = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblactivestatus = new System.Windows.Forms.Label();
            this.lblcreatedby = new System.Windows.Forms.Label();
            this.lblmodifiedby = new System.Windows.Forms.Label();
            this.blbgradetitle = new System.Windows.Forms.Label();
            this.txbgradename = new System.Windows.Forms.TextBox();
            this.txbdesc = new System.Windows.Forms.TextBox();
            this.txbcreatedby = new System.Windows.Forms.TextBox();
            this.txbmodifiedby = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblisdeleted = new System.Windows.Forms.Label();
            this.checkBoxisdeleted = new System.Windows.Forms.CheckBox();
            this.checkBoxactivestatus = new System.Windows.Forms.CheckBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.panelShowGrades = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblgradesesshow = new System.Windows.Forms.Label();
            this.btnhide = new System.Windows.Forms.Button();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.TimerSlideGrid = new System.Windows.Forms.Timer(this.components);
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelShowGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblgradename
            // 
            this.lblgradename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgradename.AutoSize = true;
            this.lblgradename.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgradename.Location = new System.Drawing.Point(59, 126);
            this.lblgradename.Name = "lblgradename";
            this.lblgradename.Size = new System.Drawing.Size(105, 24);
            this.lblgradename.TabIndex = 1;
            this.lblgradename.Text = "Grade Name";
            // 
            // lbldescription
            // 
            this.lbldescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(60, 217);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(90, 24);
            this.lbldescription.TabIndex = 2;
            this.lbldescription.Text = "Description";
            // 
            // lblactivestatus
            // 
            this.lblactivestatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblactivestatus.AutoSize = true;
            this.lblactivestatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactivestatus.Location = new System.Drawing.Point(59, 290);
            this.lblactivestatus.Name = "lblactivestatus";
            this.lblactivestatus.Size = new System.Drawing.Size(107, 24);
            this.lblactivestatus.TabIndex = 3;
            this.lblactivestatus.Text = "Active Status";
            // 
            // lblcreatedby
            // 
            this.lblcreatedby.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcreatedby.AutoSize = true;
            this.lblcreatedby.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatedby.Location = new System.Drawing.Point(569, 126);
            this.lblcreatedby.Name = "lblcreatedby";
            this.lblcreatedby.Size = new System.Drawing.Size(93, 24);
            this.lblcreatedby.TabIndex = 5;
            this.lblcreatedby.Text = "Created By";
            // 
            // lblmodifiedby
            // 
            this.lblmodifiedby.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmodifiedby.AutoSize = true;
            this.lblmodifiedby.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodifiedby.Location = new System.Drawing.Point(569, 192);
            this.lblmodifiedby.Name = "lblmodifiedby";
            this.lblmodifiedby.Size = new System.Drawing.Size(97, 24);
            this.lblmodifiedby.TabIndex = 8;
            this.lblmodifiedby.Text = "Modified By";
            // 
            // blbgradetitle
            // 
            this.blbgradetitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blbgradetitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbgradetitle.Location = new System.Drawing.Point(77, 9);
            this.blbgradetitle.Name = "blbgradetitle";
            this.blbgradetitle.Size = new System.Drawing.Size(853, 89);
            this.blbgradetitle.TabIndex = 9;
            this.blbgradetitle.Text = "GRADES";
            this.blbgradetitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbgradename
            // 
            this.txbgradename.Location = new System.Drawing.Point(203, 129);
            this.txbgradename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbgradename.Multiline = true;
            this.txbgradename.Name = "txbgradename";
            this.txbgradename.Size = new System.Drawing.Size(281, 29);
            this.txbgradename.TabIndex = 11;
            // 
            // txbdesc
            // 
            this.txbdesc.Location = new System.Drawing.Point(203, 204);
            this.txbdesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbdesc.Multiline = true;
            this.txbdesc.Name = "txbdesc";
            this.txbdesc.Size = new System.Drawing.Size(281, 31);
            this.txbdesc.TabIndex = 12;
            // 
            // txbcreatedby
            // 
            this.txbcreatedby.Location = new System.Drawing.Point(731, 119);
            this.txbcreatedby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcreatedby.Multiline = true;
            this.txbcreatedby.Name = "txbcreatedby";
            this.txbcreatedby.Size = new System.Drawing.Size(231, 29);
            this.txbcreatedby.TabIndex = 17;
            // 
            // txbmodifiedby
            // 
            this.txbmodifiedby.Location = new System.Drawing.Point(731, 185);
            this.txbmodifiedby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbmodifiedby.Multiline = true;
            this.txbmodifiedby.Name = "txbmodifiedby";
            this.txbmodifiedby.Size = new System.Drawing.Size(231, 29);
            this.txbmodifiedby.TabIndex = 18;
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(19, 468);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnadd.Size = new System.Drawing.Size(103, 43);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblisdeleted
            // 
            this.lblisdeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblisdeleted.AutoSize = true;
            this.lblisdeleted.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisdeleted.Location = new System.Drawing.Point(579, 283);
            this.lblisdeleted.Name = "lblisdeleted";
            this.lblisdeleted.Size = new System.Drawing.Size(84, 24);
            this.lblisdeleted.TabIndex = 20;
            this.lblisdeleted.Text = "Is Deleted";
            // 
            // checkBoxisdeleted
            // 
            this.checkBoxisdeleted.AutoSize = true;
            this.checkBoxisdeleted.Location = new System.Drawing.Point(731, 290);
            this.checkBoxisdeleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxisdeleted.Name = "checkBoxisdeleted";
            this.checkBoxisdeleted.Size = new System.Drawing.Size(18, 17);
            this.checkBoxisdeleted.TabIndex = 21;
            this.checkBoxisdeleted.UseVisualStyleBackColor = true;
            // 
            // checkBoxactivestatus
            // 
            this.checkBoxactivestatus.AutoSize = true;
            this.checkBoxactivestatus.Location = new System.Drawing.Point(203, 290);
            this.checkBoxactivestatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxactivestatus.Name = "checkBoxactivestatus";
            this.checkBoxactivestatus.Size = new System.Drawing.Size(18, 17);
            this.checkBoxactivestatus.TabIndex = 22;
            this.checkBoxactivestatus.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(844, 468);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(132, 43);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnshow
            // 
            this.btnshow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(554, 469);
            this.btnshow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(132, 43);
            this.btnshow.TabIndex = 24;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // panelShowGrades
            // 
            this.panelShowGrades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelShowGrades.BackColor = System.Drawing.SystemColors.Control;
            this.panelShowGrades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowGrades.Controls.Add(this.txtSearch);
            this.panelShowGrades.Controls.Add(this.lblsearch);
            this.panelShowGrades.Controls.Add(this.lblgradesesshow);
            this.panelShowGrades.Controls.Add(this.btnhide);
            this.panelShowGrades.Controls.Add(this.dataGridViewGrades);
            this.panelShowGrades.Location = new System.Drawing.Point(717, 0);
            this.panelShowGrades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShowGrades.Name = "panelShowGrades";
            this.panelShowGrades.Size = new System.Drawing.Size(450, 464);
            this.panelShowGrades.TabIndex = 25;
            this.panelShowGrades.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(233, 429);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 24);
            this.txtSearch.TabIndex = 12;
            // 
            // lblsearch
            // 
            this.lblsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblsearch.Location = new System.Drawing.Point(163, 429);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(64, 24);
            this.lblsearch.TabIndex = 3;
            this.lblsearch.Text = "Search";
            // 
            // lblgradesesshow
            // 
            this.lblgradesesshow.AutoSize = true;
            this.lblgradesesshow.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgradesesshow.Location = new System.Drawing.Point(223, 10);
            this.lblgradesesshow.Name = "lblgradesesshow";
            this.lblgradesesshow.Size = new System.Drawing.Size(80, 24);
            this.lblgradesesshow.TabIndex = 2;
            this.lblgradesesshow.Text = "GRADES";
            // 
            // btnhide
            // 
            this.btnhide.BackColor = System.Drawing.SystemColors.Control;
            this.btnhide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhide.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhide.Location = new System.Drawing.Point(3, 416);
            this.btnhide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(129, 37);
            this.btnhide.TabIndex = 1;
            this.btnhide.Text = "Hide";
            this.btnhide.UseVisualStyleBackColor = false;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Location = new System.Drawing.Point(-1, 41);
            this.dataGridViewGrades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.RowHeadersWidth = 51;
            this.dataGridViewGrades.RowTemplate.Height = 24;
            this.dataGridViewGrades.Size = new System.Drawing.Size(426, 364);
            this.dataGridViewGrades.TabIndex = 0;
            // 
            // TimerSlideGrid
            // 
            this.TimerSlideGrid.Interval = 10;
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(128, 468);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(93, 43);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(227, 469);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 43);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 523);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panelShowGrades);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.checkBoxactivestatus);
            this.Controls.Add(this.checkBoxisdeleted);
            this.Controls.Add(this.lblisdeleted);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txbmodifiedby);
            this.Controls.Add(this.txbcreatedby);
            this.Controls.Add(this.txbdesc);
            this.Controls.Add(this.txbgradename);
            this.Controls.Add(this.blbgradetitle);
            this.Controls.Add(this.lblcreatedby);
            this.Controls.Add(this.lblactivestatus);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblgradename);
            this.Controls.Add(this.lblmodifiedby);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Grades";
            this.panelShowGrades.ResumeLayout(false);
            this.panelShowGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblgradename;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblactivestatus;
        private System.Windows.Forms.Label lblcreatedby;
        private System.Windows.Forms.Label lblmodifiedby;
        private System.Windows.Forms.Label blbgradetitle;
        private System.Windows.Forms.TextBox txbgradename;
        private System.Windows.Forms.TextBox txbdesc;
        private System.Windows.Forms.TextBox txbcreatedby;
        private System.Windows.Forms.TextBox txbmodifiedby;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblisdeleted;
        private System.Windows.Forms.CheckBox checkBoxisdeleted;
        private System.Windows.Forms.CheckBox checkBoxactivestatus;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Panel panelShowGrades;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.Button btnhide;
        private System.Windows.Forms.Label lblgradesesshow;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Timer TimerSlideGrid;
        private System.Windows.Forms.Button btndelete;
        private Button btnUpdate;
    }
}

