<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.HomeBtn = New System.Windows.Forms.ToolStripButton()
        Me.PaymentBtn = New System.Windows.Forms.ToolStripButton()
        Me.AddCustBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.SearchBtn = New System.Windows.Forms.ToolStripButton()
        Me.ReportBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainUI1 = New PaymentProcessorV1_1.MainUI()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualAmortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentsToolStripMenuItem, Me.LoanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PaymentsToolStripMenuItem.Text = "Payments"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeBtn, Me.PaymentBtn, Me.AddCustBtn, Me.ToolStripButton2, Me.SearchBtn, Me.ReportBtn, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 135)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'HomeBtn
        '
        Me.HomeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeBtn.Image = Global.PaymentProcessorV1_1.My.Resources.Resources.Home_icon
        Me.HomeBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HomeBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(132, 132)
        Me.HomeBtn.Text = "ToolStripButton1"
        '
        'PaymentBtn
        '
        Me.PaymentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaymentBtn.Image = Global.PaymentProcessorV1_1.My.Resources.Resources.hand_money
        Me.PaymentBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PaymentBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PaymentBtn.Name = "PaymentBtn"
        Me.PaymentBtn.Size = New System.Drawing.Size(132, 132)
        Me.PaymentBtn.Text = "ToolStripButton2"
        '
        'AddCustBtn
        '
        Me.AddCustBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddCustBtn.Image = Global.PaymentProcessorV1_1.My.Resources.Resources.add_administrator
        Me.AddCustBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddCustBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddCustBtn.Name = "AddCustBtn"
        Me.AddCustBtn.Size = New System.Drawing.Size(132, 132)
        Me.AddCustBtn.Text = "ToolStripButton3"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.PaymentProcessorV1_1.My.Resources.Resources.businessman_edit
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(132, 132)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'SearchBtn
        '
        Me.SearchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchBtn.Image = Global.PaymentProcessorV1_1.My.Resources.Resources.search_icon
        Me.SearchBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(132, 132)
        Me.SearchBtn.Text = "ToolStripButton4"
        '
        'ReportBtn
        '
        Me.ReportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReportBtn.Image = Global.PaymentProcessorV1_1.My.Resources.Resources.reports
        Me.ReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(132, 132)
        Me.ReportBtn.Text = "ToolStripButton5"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.PaymentProcessorV1_1.My.Resources.Resources.new_loan
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(132, 132)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MainUI1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 570)
        Me.Panel1.TabIndex = 2
        '
        'MainUI1
        '
        Me.MainUI1.Location = New System.Drawing.Point(2, 2)
        Me.MainUI1.Name = "MainUI1"
        Me.MainUI1.Size = New System.Drawing.Size(1000, 570)
        Me.MainUI1.TabIndex = 0
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualAmortToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ManualAmortToolStripMenuItem
        '
        Me.ManualAmortToolStripMenuItem.Name = "ManualAmortToolStripMenuItem"
        Me.ManualAmortToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManualAmortToolStripMenuItem.Text = "Manual Amort"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "TBLA - Payment Processor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PaymentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents HomeBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents PaymentBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddCustBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MainUI1 As PaymentProcessorV1_1.MainUI
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualAmortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
