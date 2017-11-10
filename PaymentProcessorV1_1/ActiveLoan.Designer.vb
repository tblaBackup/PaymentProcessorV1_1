<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActiveLoan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ActiveCustomer = New System.Windows.Forms.DataGridView()
        Me.CustomersLoans = New System.Windows.Forms.DataGridView()
        Me.PaymentHistory = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProcessPayment1 = New PaymentProcessorV1_1.ProcessPayment()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ActiveCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersLoans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ActiveCustomer, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomersLoans, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PaymentHistory, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(992, 564)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ActiveCustomer
        '
        Me.ActiveCustomer.AllowUserToAddRows = False
        Me.ActiveCustomer.AllowUserToDeleteRows = False
        Me.ActiveCustomer.AllowUserToOrderColumns = True
        Me.ActiveCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActiveCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActiveCustomer.Location = New System.Drawing.Point(5, 5)
        Me.ActiveCustomer.Name = "ActiveCustomer"
        Me.ActiveCustomer.ReadOnly = True
        Me.ActiveCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ActiveCustomer.Size = New System.Drawing.Size(487, 273)
        Me.ActiveCustomer.TabIndex = 0
        '
        'CustomersLoans
        '
        Me.CustomersLoans.AllowUserToAddRows = False
        Me.CustomersLoans.AllowUserToDeleteRows = False
        Me.CustomersLoans.AllowUserToOrderColumns = True
        Me.CustomersLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersLoans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomersLoans.Location = New System.Drawing.Point(5, 286)
        Me.CustomersLoans.Name = "CustomersLoans"
        Me.CustomersLoans.ReadOnly = True
        Me.CustomersLoans.Size = New System.Drawing.Size(487, 273)
        Me.CustomersLoans.TabIndex = 1
        '
        'PaymentHistory
        '
        Me.PaymentHistory.AllowUserToAddRows = False
        Me.PaymentHistory.AllowUserToDeleteRows = False
        Me.PaymentHistory.AllowUserToOrderColumns = True
        Me.PaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaymentHistory.Location = New System.Drawing.Point(500, 5)
        Me.PaymentHistory.Name = "PaymentHistory"
        Me.PaymentHistory.ReadOnly = True
        Me.PaymentHistory.Size = New System.Drawing.Size(487, 273)
        Me.PaymentHistory.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProcessPayment1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(500, 286)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 273)
        Me.Panel1.TabIndex = 3
        '
        'ProcessPayment1
        '
        Me.ProcessPayment1.Location = New System.Drawing.Point(2, 3)
        Me.ProcessPayment1.Name = "ProcessPayment1"
        Me.ProcessPayment1.Size = New System.Drawing.Size(482, 273)
        Me.ProcessPayment1.TabIndex = 0
        '
        'ActiveLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ActiveLoan"
        Me.Size = New System.Drawing.Size(1000, 570)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ActiveCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersLoans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ActiveCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents CustomersLoans As System.Windows.Forms.DataGridView
    Friend WithEvents PaymentHistory As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProcessPayment1 As PaymentProcessorV1_1.ProcessPayment

End Class
