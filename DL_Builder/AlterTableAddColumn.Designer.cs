namespace DL_Builder
{
    partial class AlterTableAddColumn
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateSql = new System.Windows.Forms.Button();
            this.txtSqlResult = new System.Windows.Forms.TextBox();
            this.txtSqlSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDesc = new System.Windows.Forms.CheckBox();
            this.chkDefaultValue = new System.Windows.Forms.CheckBox();
            this.chkIsNull = new System.Windows.Forms.CheckBox();
            this.chkType = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "生成代码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "源数据：";
            // 
            // btnCreateSql
            // 
            this.btnCreateSql.Location = new System.Drawing.Point(430, 623);
            this.btnCreateSql.Name = "btnCreateSql";
            this.btnCreateSql.Size = new System.Drawing.Size(200, 30);
            this.btnCreateSql.TabIndex = 29;
            this.btnCreateSql.Text = "新增字段";
            this.btnCreateSql.UseVisualStyleBackColor = true;
            this.btnCreateSql.Click += new System.EventHandler(this.createSQL_Click);
            // 
            // txtSqlResult
            // 
            this.txtSqlResult.Location = new System.Drawing.Point(424, 51);
            this.txtSqlResult.Multiline = true;
            this.txtSqlResult.Name = "txtSqlResult";
            this.txtSqlResult.Size = new System.Drawing.Size(400, 502);
            this.txtSqlResult.TabIndex = 28;
            this.txtSqlResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currentData_KeyDown);
            // 
            // txtSqlSource
            // 
            this.txtSqlSource.Location = new System.Drawing.Point(0, 51);
            this.txtSqlSource.Multiline = true;
            this.txtSqlSource.Name = "txtSqlSource";
            this.txtSqlSource.Size = new System.Drawing.Size(400, 502);
            this.txtSqlSource.TabIndex = 27;
            this.txtSqlSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.originalData_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "其他列（*）";
            // 
            // chkDesc
            // 
            this.chkDesc.AutoSize = true;
            this.chkDesc.Location = new System.Drawing.Point(520, 583);
            this.chkDesc.Name = "chkDesc";
            this.chkDesc.Size = new System.Drawing.Size(102, 16);
            this.chkDesc.TabIndex = 30;
            this.chkDesc.Text = "字段说明（D）";
            this.chkDesc.UseVisualStyleBackColor = true;
            this.chkDesc.CheckedChanged += new System.EventHandler(this.chkDesc_CheckedChanged);
            // 
            // chkDefaultValue
            // 
            this.chkDefaultValue.AutoSize = true;
            this.chkDefaultValue.Location = new System.Drawing.Point(410, 583);
            this.chkDefaultValue.Name = "chkDefaultValue";
            this.chkDefaultValue.Size = new System.Drawing.Size(90, 16);
            this.chkDefaultValue.TabIndex = 29;
            this.chkDefaultValue.Text = "默认值（V）";
            this.chkDefaultValue.UseVisualStyleBackColor = true;
            this.chkDefaultValue.CheckedChanged += new System.EventHandler(this.chkDefaultValue_CheckedChanged);
            // 
            // chkIsNull
            // 
            this.chkIsNull.AutoSize = true;
            this.chkIsNull.Location = new System.Drawing.Point(300, 583);
            this.chkIsNull.Name = "chkIsNull";
            this.chkIsNull.Size = new System.Drawing.Size(90, 16);
            this.chkIsNull.TabIndex = 28;
            this.chkIsNull.Text = "是否NULL(N)";
            this.chkIsNull.UseVisualStyleBackColor = true;
            this.chkIsNull.CheckedChanged += new System.EventHandler(this.chkIsNull_CheckedChanged);
            // 
            // chkType
            // 
            this.chkType.AutoSize = true;
            this.chkType.Location = new System.Drawing.Point(190, 583);
            this.chkType.Name = "chkType";
            this.chkType.Size = new System.Drawing.Size(102, 16);
            this.chkType.TabIndex = 27;
            this.chkType.Text = "字段类型（T）";
            this.chkType.UseVisualStyleBackColor = true;
            this.chkType.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(80, 583);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(102, 16);
            this.chkName.TabIndex = 26;
            this.chkName.Text = "字段名称（M）";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "生成规则：";
            // 
            // txtRule
            // 
            this.txtRule.Location = new System.Drawing.Point(150, 628);
            this.txtRule.Name = "txtRule";
            this.txtRule.Size = new System.Drawing.Size(257, 21);
            this.txtRule.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(367, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "新增字段";
            // 
            // AlterTableAddColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 673);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkDesc);
            this.Controls.Add(this.chkDefaultValue);
            this.Controls.Add(this.chkIsNull);
            this.Controls.Add(this.chkType);
            this.Controls.Add(this.chkName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateSql);
            this.Controls.Add(this.txtSqlResult);
            this.Controls.Add(this.txtSqlSource);
            this.MaximizeBox = false;
            this.Name = "AlterTableAddColumn";
            this.Text = "新增字段";
            this.Load += new System.EventHandler(this.Table_Add_Column_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateSql;
        private System.Windows.Forms.TextBox txtSqlResult;
        private System.Windows.Forms.TextBox txtSqlSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDesc;
        private System.Windows.Forms.CheckBox chkDefaultValue;
        private System.Windows.Forms.CheckBox chkIsNull;
        private System.Windows.Forms.CheckBox chkType;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRule;
        private System.Windows.Forms.Label label5;
    }
}