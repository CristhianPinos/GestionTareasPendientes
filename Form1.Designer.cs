namespace GestionTareasPendientes
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
            this.txt_Tarea = new System.Windows.Forms.TextBox();
            this.btn_AgregarTarea = new System.Windows.Forms.Button();
            this.lst_Tareas = new System.Windows.Forms.ListBox();
            this.btn_EliminarTarea = new System.Windows.Forms.Button();
            this.btn_LimpiarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Tarea
            // 
            this.txt_Tarea.Location = new System.Drawing.Point(310, 27);
            this.txt_Tarea.MaxLength = 255;
            this.txt_Tarea.Name = "txt_Tarea";
            this.txt_Tarea.Size = new System.Drawing.Size(872, 34);
            this.txt_Tarea.TabIndex = 0;
            // 
            // btn_AgregarTarea
            // 
            this.btn_AgregarTarea.Location = new System.Drawing.Point(667, 73);
            this.btn_AgregarTarea.Name = "btn_AgregarTarea";
            this.btn_AgregarTarea.Size = new System.Drawing.Size(158, 66);
            this.btn_AgregarTarea.TabIndex = 1;
            this.btn_AgregarTarea.Text = "Agregar Tarea";
            this.btn_AgregarTarea.UseVisualStyleBackColor = true;
            this.btn_AgregarTarea.Click += new System.EventHandler(this.btn_AgregarTarea_Click);
            // 
            // lst_Tareas
            // 
            this.lst_Tareas.FormattingEnabled = true;
            this.lst_Tareas.ItemHeight = 29;
            this.lst_Tareas.Location = new System.Drawing.Point(310, 161);
            this.lst_Tareas.Name = "lst_Tareas";
            this.lst_Tareas.Size = new System.Drawing.Size(872, 497);
            this.lst_Tareas.TabIndex = 2;
            // 
            // btn_EliminarTarea
            // 
            this.btn_EliminarTarea.Location = new System.Drawing.Point(511, 679);
            this.btn_EliminarTarea.Name = "btn_EliminarTarea";
            this.btn_EliminarTarea.Size = new System.Drawing.Size(158, 66);
            this.btn_EliminarTarea.TabIndex = 3;
            this.btn_EliminarTarea.Text = "Eliminar Tarea";
            this.btn_EliminarTarea.UseVisualStyleBackColor = true;
            this.btn_EliminarTarea.Click += new System.EventHandler(this.btn_EliminarTarea_Click);
            // 
            // btn_LimpiarLista
            // 
            this.btn_LimpiarLista.Location = new System.Drawing.Point(837, 679);
            this.btn_LimpiarLista.Name = "btn_LimpiarLista";
            this.btn_LimpiarLista.Size = new System.Drawing.Size(156, 66);
            this.btn_LimpiarLista.TabIndex = 4;
            this.btn_LimpiarLista.Text = "Limpiar Lista";
            this.btn_LimpiarLista.UseVisualStyleBackColor = true;
            this.btn_LimpiarLista.Click += new System.EventHandler(this.btn_LimpiarLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.btn_LimpiarLista);
            this.Controls.Add(this.btn_EliminarTarea);
            this.Controls.Add(this.lst_Tareas);
            this.Controls.Add(this.btn_AgregarTarea);
            this.Controls.Add(this.txt_Tarea);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "TareasPendientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Tarea;
        private System.Windows.Forms.Button btn_AgregarTarea;
        private System.Windows.Forms.ListBox lst_Tareas;
        private System.Windows.Forms.Button btn_EliminarTarea;
        private System.Windows.Forms.Button btn_LimpiarLista;
    }
}

