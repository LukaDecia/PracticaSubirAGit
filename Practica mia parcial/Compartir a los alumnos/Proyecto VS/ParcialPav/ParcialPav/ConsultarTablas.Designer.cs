namespace ParcialPav
{
    partial class ConsultarTablas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaEquipos = new System.Windows.Forms.DataGridView();
            this.grillaJugadoresXEquipo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaJugadoresXEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listado de Equipos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Jugadores Por Equipo";
            // 
            // grillaEquipos
            // 
            this.grillaEquipos.AllowUserToAddRows = false;
            this.grillaEquipos.AllowUserToDeleteRows = false;
            this.grillaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.FechaCreacion});
            this.grillaEquipos.Location = new System.Drawing.Point(17, 48);
            this.grillaEquipos.Name = "grillaEquipos";
            this.grillaEquipos.ReadOnly = true;
            this.grillaEquipos.Size = new System.Drawing.Size(577, 150);
            this.grillaEquipos.TabIndex = 3;
            // 
            // grillaJugadoresXEquipo
            // 
            this.grillaJugadoresXEquipo.AllowUserToAddRows = false;
            this.grillaJugadoresXEquipo.AllowUserToDeleteRows = false;
            this.grillaJugadoresXEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaJugadoresXEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idd,
            this.IdJugador,
            this.IdEquipo,
            this.FechaAsignacion});
            this.grillaJugadoresXEquipo.Location = new System.Drawing.Point(17, 263);
            this.grillaJugadoresXEquipo.Name = "grillaJugadoresXEquipo";
            this.grillaJugadoresXEquipo.ReadOnly = true;
            this.grillaJugadoresXEquipo.Size = new System.Drawing.Size(577, 150);
            this.grillaJugadoresXEquipo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 234);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "FechaCreacion";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            // 
            // Idd
            // 
            this.Idd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Idd.DataPropertyName = "Id";
            this.Idd.HeaderText = "Idd";
            this.Idd.Name = "Idd";
            this.Idd.ReadOnly = true;
            // 
            // IdJugador
            // 
            this.IdJugador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdJugador.DataPropertyName = "IdJugador";
            this.IdJugador.HeaderText = "IdJugador";
            this.IdJugador.Name = "IdJugador";
            this.IdJugador.ReadOnly = true;
            // 
            // IdEquipo
            // 
            this.IdEquipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdEquipo.DataPropertyName = "IdEquipo";
            this.IdEquipo.HeaderText = "IdEquipo";
            this.IdEquipo.Name = "IdEquipo";
            this.IdEquipo.ReadOnly = true;
            // 
            // FechaAsignacion
            // 
            this.FechaAsignacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaAsignacion.DataPropertyName = "FechaAsignacion";
            this.FechaAsignacion.HeaderText = "FechaAsignacion";
            this.FechaAsignacion.Name = "FechaAsignacion";
            this.FechaAsignacion.ReadOnly = true;
            // 
            // ConsultarTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.grillaJugadoresXEquipo);
            this.Controls.Add(this.grillaEquipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultarTablas";
            this.Text = "ConsultarTablas";
            this.Load += new System.EventHandler(this.ConsultarTablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaJugadoresXEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaEquipos;
        private System.Windows.Forms.DataGridView grillaJugadoresXEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAsignacion;
    }
}