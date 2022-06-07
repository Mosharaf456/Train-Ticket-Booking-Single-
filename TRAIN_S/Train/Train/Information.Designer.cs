namespace Train
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.btnprevious = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.dgvtrainlist = new System.Windows.Forms.DataGridView();
            this.trainDataSet2 = new Train.TrainDataSet2();
            this.trainscheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainscheduleTableAdapter = new Train.TrainDataSet2TableAdapters.trainscheduleTableAdapter();
            this.dgvuserlist = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Train.TrainDataSet2TableAdapters.usersTableAdapter();
            this.trainDataSet = new Train.TrainDataSet();
            this.trainscheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainscheduleTableAdapter1 = new Train.TrainDataSetTableAdapters.trainscheduleTableAdapter();
            this.trainscheduleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trainDataSet3 = new Train.TrainDataSet3();
            this.trainscheduleBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.trainscheduleTableAdapter2 = new Train.TrainDataSet3TableAdapters.trainscheduleTableAdapter();
            this.trainscheduleBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.btntrainlist = new System.Windows.Forms.Button();
            this.btnuserList = new System.Windows.Forms.Button();
            this.infmlblid = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrainlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnprevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.Location = new System.Drawing.Point(25, 464);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(121, 47);
            this.btnprevious.TabIndex = 0;
            this.btnprevious.Text = "Previous";
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblstatus.Location = new System.Drawing.Point(37, 24);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(56, 20);
            this.lblstatus.TabIndex = 1;
            this.lblstatus.Text = "Status";
            // 
            // dgvtrainlist
            // 
            this.dgvtrainlist.AllowUserToOrderColumns = true;
            this.dgvtrainlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtrainlist.Location = new System.Drawing.Point(25, 111);
            this.dgvtrainlist.Name = "dgvtrainlist";
            this.dgvtrainlist.RowTemplate.Height = 28;
            this.dgvtrainlist.Size = new System.Drawing.Size(472, 308);
            this.dgvtrainlist.TabIndex = 2;
            // 
            // trainDataSet2
            // 
            this.trainDataSet2.DataSetName = "TrainDataSet2";
            this.trainDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainscheduleBindingSource
            // 
            this.trainscheduleBindingSource.DataMember = "trainschedule";
            this.trainscheduleBindingSource.DataSource = this.trainDataSet2;
            // 
            // trainscheduleTableAdapter
            // 
            this.trainscheduleTableAdapter.ClearBeforeFill = true;
            // 
            // dgvuserlist
            // 
            this.dgvuserlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuserlist.Location = new System.Drawing.Point(542, 111);
            this.dgvuserlist.Name = "dgvuserlist";
            this.dgvuserlist.RowTemplate.Height = 28;
            this.dgvuserlist.Size = new System.Drawing.Size(460, 308);
            this.dgvuserlist.TabIndex = 3;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.trainDataSet2;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // trainDataSet
            // 
            this.trainDataSet.DataSetName = "TrainDataSet";
            this.trainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainscheduleBindingSource1
            // 
            this.trainscheduleBindingSource1.DataMember = "trainschedule";
            this.trainscheduleBindingSource1.DataSource = this.trainDataSet;
            // 
            // trainscheduleTableAdapter1
            // 
            this.trainscheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // trainscheduleBindingSource2
            // 
            this.trainscheduleBindingSource2.DataMember = "trainschedule";
            this.trainscheduleBindingSource2.DataSource = this.trainDataSet2;
            // 
            // trainDataSet3
            // 
            this.trainDataSet3.DataSetName = "TrainDataSet3";
            this.trainDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainscheduleBindingSource3
            // 
            this.trainscheduleBindingSource3.DataMember = "trainschedule";
            this.trainscheduleBindingSource3.DataSource = this.trainDataSet3;
            // 
            // trainscheduleTableAdapter2
            // 
            this.trainscheduleTableAdapter2.ClearBeforeFill = true;
            // 
            // trainscheduleBindingSource4
            // 
            this.trainscheduleBindingSource4.DataMember = "trainschedule";
            this.trainscheduleBindingSource4.DataSource = this.trainDataSet2;
            // 
            // btntrainlist
            // 
            this.btntrainlist.BackColor = System.Drawing.Color.Transparent;
            this.btntrainlist.Location = new System.Drawing.Point(380, 17);
            this.btntrainlist.Name = "btntrainlist";
            this.btntrainlist.Size = new System.Drawing.Size(117, 34);
            this.btntrainlist.TabIndex = 4;
            this.btntrainlist.Text = "Train List";
            this.btntrainlist.UseVisualStyleBackColor = false;
            this.btntrainlist.Click += new System.EventHandler(this.btntrainlist_Click);
            // 
            // btnuserList
            // 
            this.btnuserList.BackColor = System.Drawing.Color.Transparent;
            this.btnuserList.Location = new System.Drawing.Point(578, 17);
            this.btnuserList.Name = "btnuserList";
            this.btnuserList.Size = new System.Drawing.Size(123, 36);
            this.btnuserList.TabIndex = 5;
            this.btnuserList.Text = "User List";
            this.btnuserList.UseVisualStyleBackColor = false;
            this.btnuserList.Click += new System.EventHandler(this.btnuserList_Click);
            // 
            // infmlblid
            // 
            this.infmlblid.AutoSize = true;
            this.infmlblid.Location = new System.Drawing.Point(108, 24);
            this.infmlblid.Name = "infmlblid";
            this.infmlblid.Size = new System.Drawing.Size(21, 20);
            this.infmlblid.TabIndex = 6;
            this.infmlblid.Text = "id";
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Red;
            this.lblexit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.Location = new System.Drawing.Point(1004, 0);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(34, 34);
            this.lblexit.TabIndex = 7;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1040, 593);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.infmlblid);
            this.Controls.Add(this.btnuserList);
            this.Controls.Add(this.btntrainlist);
            this.Controls.Add(this.dgvuserlist);
            this.Controls.Add(this.dgvtrainlist);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnprevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainList and UserList";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrainlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.DataGridView dgvtrainlist;
        private TrainDataSet2 trainDataSet2;
        private System.Windows.Forms.BindingSource trainscheduleBindingSource;
        private TrainDataSet2TableAdapters.trainscheduleTableAdapter trainscheduleTableAdapter;
        private System.Windows.Forms.DataGridView dgvuserlist;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private TrainDataSet2TableAdapters.usersTableAdapter usersTableAdapter;
        private TrainDataSet trainDataSet;
        private System.Windows.Forms.BindingSource trainscheduleBindingSource1;
        private TrainDataSetTableAdapters.trainscheduleTableAdapter trainscheduleTableAdapter1;
        private System.Windows.Forms.BindingSource trainscheduleBindingSource2;
        private TrainDataSet3 trainDataSet3;
        private System.Windows.Forms.BindingSource trainscheduleBindingSource3;
        private TrainDataSet3TableAdapters.trainscheduleTableAdapter trainscheduleTableAdapter2;
        private System.Windows.Forms.BindingSource trainscheduleBindingSource4;
        private System.Windows.Forms.Button btntrainlist;
        private System.Windows.Forms.Button btnuserList;
        private System.Windows.Forms.Label infmlblid;
        private System.Windows.Forms.Label lblexit;
    }
}