<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTask
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressLabel2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar2.Location = New System.Drawing.Point(14, 97)
        Me.ProgressBar2.Maximum = 9
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(774, 23)
        Me.ProgressBar2.TabIndex = 15
        '
        'ProgressLabel2
        '
        Me.ProgressLabel2.AutoSize = True
        Me.ProgressLabel2.Location = New System.Drawing.Point(53, 69)
        Me.ProgressLabel2.Name = "ProgressLabel2"
        Me.ProgressLabel2.Size = New System.Drawing.Size(38, 12)
        Me.ProgressLabel2.TabIndex = 14
        Me.ProgressLabel2.Text = "Label2"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 26)
        Me.ProgressBar1.Maximum = 9
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(776, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "進捗2"
        '
        'ProgressLabel1
        '
        Me.ProgressLabel1.AutoSize = True
        Me.ProgressLabel1.Location = New System.Drawing.Point(53, 11)
        Me.ProgressLabel1.Name = "ProgressLabel1"
        Me.ProgressLabel1.Size = New System.Drawing.Size(38, 12)
        Me.ProgressLabel1.TabIndex = 11
        Me.ProgressLabel1.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "進捗1"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(632, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "中止"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "実行"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressLabel2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormTask"
        Me.Text = "FormTask"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressLabel2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressLabel1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
