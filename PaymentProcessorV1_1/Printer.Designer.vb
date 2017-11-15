<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Printer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Printer))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddressLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AmtLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PaymentProcessorV1_1.My.Resources.Resources.tbla_logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 116)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Receipt#"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.00868!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.99132!))
        Me.TableLayoutPanel1.Controls.Add(Me.AmtLbl, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DateLbl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AddressLbl, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NameLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(62, 173)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(461, 146)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'NameLbl
        '
        Me.NameLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Location = New System.Drawing.Point(294, 11)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(39, 13)
        Me.NameLbl.TabIndex = 1
        Me.NameLbl.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Payment Date"
        '
        'AddressLbl
        '
        Me.AddressLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddressLbl.AutoSize = True
        Me.AddressLbl.Location = New System.Drawing.Point(294, 46)
        Me.AddressLbl.Name = "AddressLbl"
        Me.AddressLbl.Size = New System.Drawing.Size(39, 13)
        Me.AddressLbl.TabIndex = 3
        Me.AddressLbl.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Amount Submitted"
        '
        'DateLbl
        '
        Me.DateLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Location = New System.Drawing.Point(294, 81)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(39, 13)
        Me.DateLbl.TabIndex = 5
        Me.DateLbl.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Address"
        '
        'AmtLbl
        '
        Me.AmtLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AmtLbl.AutoSize = True
        Me.AmtLbl.Location = New System.Drawing.Point(294, 119)
        Me.AmtLbl.Name = "AmtLbl"
        Me.AmtLbl.Size = New System.Drawing.Size(39, 13)
        Me.AmtLbl.TabIndex = 7
        Me.AmtLbl.Text = "Label9"
        '
        'Printer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 741)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Printer"
        Me.Text = "Printer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AmtLbl As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateLbl As System.Windows.Forms.Label
    Friend WithEvents AddressLbl As System.Windows.Forms.Label
    Friend WithEvents NameLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
