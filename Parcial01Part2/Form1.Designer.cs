
namespace Parcial01Part2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxTipoCarta = new System.Windows.Forms.ComboBox();
            this.comboBoxCarta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCartasMayores = new System.Windows.Forms.Button();
            this.pictureBoxCarta = new System.Windows.Forms.PictureBox();
            this.dataGViewInfoCartas = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewInfoCartas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipoCarta
            // 
            this.comboBoxTipoCarta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoCarta.FormattingEnabled = true;
            this.comboBoxTipoCarta.Location = new System.Drawing.Point(12, 110);
            this.comboBoxTipoCarta.Name = "comboBoxTipoCarta";
            this.comboBoxTipoCarta.Size = new System.Drawing.Size(153, 21);
            this.comboBoxTipoCarta.TabIndex = 0;
            this.comboBoxTipoCarta.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoCarta_SelectedIndexChanged);
            // 
            // comboBoxCarta
            // 
            this.comboBoxCarta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarta.FormattingEnabled = true;
            this.comboBoxCarta.Location = new System.Drawing.Point(216, 40);
            this.comboBoxCarta.Name = "comboBoxCarta";
            this.comboBoxCarta.Size = new System.Drawing.Size(144, 21);
            this.comboBoxCarta.TabIndex = 1;
            this.comboBoxCarta.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipos de cartas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carta";
            // 
            // btCartasMayores
            // 
            this.btCartasMayores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCartasMayores.Location = new System.Drawing.Point(12, 154);
            this.btCartasMayores.Name = "btCartasMayores";
            this.btCartasMayores.Size = new System.Drawing.Size(153, 52);
            this.btCartasMayores.TabIndex = 4;
            this.btCartasMayores.Text = "Cartas con mayor elixir";
            this.btCartasMayores.UseVisualStyleBackColor = true;
            this.btCartasMayores.Click += new System.EventHandler(this.btCartasMayores_Click);
            // 
            // pictureBoxCarta
            // 
            this.pictureBoxCarta.Location = new System.Drawing.Point(216, 87);
            this.pictureBoxCarta.Name = "pictureBoxCarta";
            this.pictureBoxCarta.Size = new System.Drawing.Size(144, 169);
            this.pictureBoxCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarta.TabIndex = 5;
            this.pictureBoxCarta.TabStop = false;
            // 
            // dataGViewInfoCartas
            // 
            this.dataGViewInfoCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGViewInfoCartas.Location = new System.Drawing.Point(15, 291);
            this.dataGViewInfoCartas.Name = "dataGViewInfoCartas";
            this.dataGViewInfoCartas.Size = new System.Drawing.Size(365, 174);
            this.dataGViewInfoCartas.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 476);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(12, 236);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(194, 30);
            this.btnCategoria.TabIndex = 12;
            this.btnCategoria.Text = "Ir a categoria de cartas";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 477);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGViewInfoCartas);
            this.Controls.Add(this.pictureBoxCarta);
            this.Controls.Add(this.btCartasMayores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCarta);
            this.Controls.Add(this.comboBoxTipoCarta);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewInfoCartas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoCarta;
        private System.Windows.Forms.ComboBox comboBoxCarta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCartasMayores;
        private System.Windows.Forms.PictureBox pictureBoxCarta;
        private System.Windows.Forms.DataGridView dataGViewInfoCartas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCategoria;
    }
}

