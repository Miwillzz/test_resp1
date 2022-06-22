<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.lblnombreusuario = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btninicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.btninventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.btncategoria = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnusuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnpass = New System.Windows.Forms.ToolStripMenuItem()
        Me.btbnsalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(5)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btninicio, Me.btninventario, Me.btncategoria, Me.btnusuario, Me.btnpass, Me.btbnsalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(20, 10, 0, 10)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 42)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.lblnombreusuario})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 646)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip2.Size = New System.Drawing.Size(1264, 35)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'lblnombreusuario
        '
        Me.lblnombreusuario.BackColor = System.Drawing.Color.SeaGreen
        Me.lblnombreusuario.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreusuario.ForeColor = System.Drawing.Color.White
        Me.lblnombreusuario.Name = "lblnombreusuario"
        Me.lblnombreusuario.Size = New System.Drawing.Size(100, 29)
        Me.lblnombreusuario.Text = "lblusuario"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.White
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1264, 604)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 42)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1264, 604)
        Me.ToolStripContainer1.TabIndex = 4
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Image = Global.VaidrollTeamWindowsApp1.My.Resources.Resources.user3
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(93, 29)
        Me.ToolStripMenuItem1.Text = "Usuario"
        '
        'btninicio
        '
        Me.btninicio.ForeColor = System.Drawing.Color.White
        Me.btninicio.Image = Global.VaidrollTeamWindowsApp1.My.Resources.Resources.home2
        Me.btninicio.Name = "btninicio"
        Me.btninicio.Padding = New System.Windows.Forms.Padding(4, 0, 10, 0)
        Me.btninicio.Size = New System.Drawing.Size(78, 22)
        Me.btninicio.Text = "Inicio"
        '
        'btninventario
        '
        Me.btninventario.ForeColor = System.Drawing.Color.White
        Me.btninventario.Image = Global.VaidrollTeamWindowsApp1.My.Resources.Resources.inven
        Me.btninventario.Name = "btninventario"
        Me.btninventario.Padding = New System.Windows.Forms.Padding(4, 0, 10, 0)
        Me.btninventario.Size = New System.Drawing.Size(108, 22)
        Me.btninventario.Text = "Inventario"
        '
        'btncategoria
        '
        Me.btncategoria.ForeColor = System.Drawing.Color.White
        Me.btncategoria.Image = Global.VaidrollTeamWindowsApp1.My.Resources.Resources.categoria
        Me.btncategoria.Name = "btncategoria"
        Me.btncategoria.Padding = New System.Windows.Forms.Padding(4, 0, 10, 0)
        Me.btncategoria.Size = New System.Drawing.Size(111, 22)
        Me.btncategoria.Text = "Categoría"
        '
        'btnusuario
        '
        Me.btnusuario.ForeColor = System.Drawing.Color.White
        Me.btnusuario.Image = Global.VaidrollTeamWindowsApp1.My.Resources.Resources.us
        Me.btnusuario.Name = "btnusuario"
        Me.btnusuario.Padding = New System.Windows.Forms.Padding(4, 0, 10, 0)
        Me.btnusuario.Size = New System.Drawing.Size(104, 22)
        Me.btnusuario.Text = "Usuarios"
        '
        'btnpass
        '
        Me.btnpass.ForeColor = System.Drawing.Color.White
        Me.btnpass.Image = Global.VaidrollTeamWindowsApp1.My.Resources.Resources.pass
        Me.btnpass.Name = "btnpass"
        Me.btnpass.Padding = New System.Windows.Forms.Padding(4, 0, 50, 0)
        Me.btnpass.Size = New System.Drawing.Size(224, 22)
        Me.btnpass.Text = "Cambiar contraseña"
        '
        'btbnsalir
        '
        Me.btbnsalir.ForeColor = System.Drawing.Color.White
        Me.btbnsalir.Image = Global.VaidrollTeamWindowsApp1.My.Resources.Resources.salir
        Me.btbnsalir.Name = "btbnsalir"
        Me.btbnsalir.Size = New System.Drawing.Size(68, 22)
        Me.btbnsalir.Text = "Salir"
        '
        'Principal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de inventario"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btninventario As ToolStripMenuItem
    Friend WithEvents btncategoria As ToolStripMenuItem
    Friend WithEvents btninicio As ToolStripMenuItem
    Friend WithEvents btnusuario As ToolStripMenuItem
    Friend WithEvents btbnsalir As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents lblnombreusuario As ToolStripTextBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents btnpass As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
