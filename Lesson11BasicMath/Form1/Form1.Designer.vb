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
        Me.txtFirstValue = New System.Windows.Forms.TextBox()
        Me.txtSecondValue = New System.Windows.Forms.TextBox()
        Me.btnSummarize = New System.Windows.Forms.Button()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirstValue
        '
        Me.txtFirstValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.txtFirstValue.Location = New System.Drawing.Point(114, 42)
        Me.txtFirstValue.Name = "txtFirstValue"
        Me.txtFirstValue.Size = New System.Drawing.Size(169, 68)
        Me.txtFirstValue.TabIndex = 0
        '
        'txtSecondValue
        '
        Me.txtSecondValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.txtSecondValue.Location = New System.Drawing.Point(517, 42)
        Me.txtSecondValue.Name = "txtSecondValue"
        Me.txtSecondValue.Size = New System.Drawing.Size(169, 68)
        Me.txtSecondValue.TabIndex = 1
        '
        'btnSummarize
        '
        Me.btnSummarize.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.btnSummarize.Location = New System.Drawing.Point(245, 124)
        Me.btnSummarize.Name = "btnSummarize"
        Me.btnSummarize.Size = New System.Drawing.Size(310, 68)
        Me.btnSummarize.TabIndex = 2
        Me.btnSummarize.Text = "Summarize"
        Me.btnSummarize.UseVisualStyleBackColor = True
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.lblSummary.Location = New System.Drawing.Point(38, 279)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(0, 63)
        Me.lblSummary.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.btnSummarize)
        Me.Controls.Add(Me.txtSecondValue)
        Me.Controls.Add(Me.txtFirstValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstValue As TextBox
    Friend WithEvents txtSecondValue As TextBox
    Friend WithEvents btnSummarize As Button
    Friend WithEvents lblSummary As Label
End Class
