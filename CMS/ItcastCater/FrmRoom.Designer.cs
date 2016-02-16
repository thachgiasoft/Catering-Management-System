﻿namespace ItcastCater
{
    partial class FrmRoom
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
            this.btnUpdateDesk = new System.Windows.Forms.Button();
            this.btnAddDesk = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dgvRoomInfo = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDeskInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeskInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateDesk
            // 
            this.btnUpdateDesk.Location = new System.Drawing.Point(615, 349);
            this.btnUpdateDesk.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDesk.Name = "btnUpdateDesk";
            this.btnUpdateDesk.Size = new System.Drawing.Size(100, 31);
            this.btnUpdateDesk.TabIndex = 39;
            this.btnUpdateDesk.Text = "修改餐桌";
            this.btnUpdateDesk.UseVisualStyleBackColor = true;
            // 
            // btnAddDesk
            // 
            this.btnAddDesk.Location = new System.Drawing.Point(615, 289);
            this.btnAddDesk.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDesk.Name = "btnAddDesk";
            this.btnAddDesk.Size = new System.Drawing.Size(100, 31);
            this.btnAddDesk.TabIndex = 38;
            this.btnAddDesk.Text = "添加餐桌";
            this.btnAddDesk.UseVisualStyleBackColor = true;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(615, 32);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(120, 31);
            this.btnAddRoom.TabIndex = 35;
            this.btnAddRoom.Text = "增加房间";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // dgvRoomInfo
            // 
            this.dgvRoomInfo.AllowUserToAddRows = false;
            this.dgvRoomInfo.AllowUserToDeleteRows = false;
            this.dgvRoomInfo.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvRoomInfo.Location = new System.Drawing.Point(68, 1);
            this.dgvRoomInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRoomInfo.Name = "dgvRoomInfo";
            this.dgvRoomInfo.ReadOnly = true;
            this.dgvRoomInfo.RowHeadersVisible = false;
            this.dgvRoomInfo.RowTemplate.Height = 23;
            this.dgvRoomInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomInfo.Size = new System.Drawing.Size(539, 240);
            this.dgvRoomInfo.TabIndex = 32;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(615, 414);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 31);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "删除餐桌";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(615, 170);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(120, 31);
            this.btnDeleteRoom.TabIndex = 34;
            this.btnDeleteRoom.Text = "删除房间";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 33;
            this.button2.Text = "修改房间";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvDeskInfo
            // 
            this.dgvDeskInfo.AllowUserToAddRows = false;
            this.dgvDeskInfo.AllowUserToDeleteRows = false;
            this.dgvDeskInfo.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvDeskInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeskInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column12,
            this.Column11});
            this.dgvDeskInfo.Location = new System.Drawing.Point(68, 276);
            this.dgvDeskInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDeskInfo.Name = "dgvDeskInfo";
            this.dgvDeskInfo.ReadOnly = true;
            this.dgvDeskInfo.RowHeadersVisible = false;
            this.dgvDeskInfo.RowTemplate.Height = 23;
            this.dgvDeskInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeskInfo.Size = new System.Drawing.Size(539, 200);
            this.dgvDeskInfo.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeskId";
            this.dataGridViewTextBoxColumn1.HeaderText = "餐桌id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DeskName";
            this.Column7.HeaderText = "餐桌编号";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DeskRegion";
            this.Column8.HeaderText = "餐桌描述";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DeskState";
            this.Column9.HeaderText = "餐桌状态";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "DeskRemark";
            this.Column12.HeaderText = "餐桌备注";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "RoomId";
            this.Column11.HeaderText = "房间类型";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RoomId";
            this.Column1.HeaderText = "房间的id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "RoomName";
            this.Column2.HeaderText = "房间的名字";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "RoomMinimunConsume";
            this.Column3.HeaderText = "房间最低消费";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RoomMaxConsumer";
            this.Column4.HeaderText = "房间人数";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IsDefault";
            this.Column5.HeaderText = "默认编号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "RoomType";
            this.Column6.HeaderText = "房间类型";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 477);
            this.Controls.Add(this.btnUpdateDesk);
            this.Controls.Add(this.btnAddDesk);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.dgvRoomInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvDeskInfo);
            this.Name = "FrmRoom";
            this.Text = "FrmRoom";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeskInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateDesk;
        private System.Windows.Forms.Button btnAddDesk;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DataGridView dgvRoomInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvDeskInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}