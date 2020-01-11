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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.player1 = New System.Windows.Forms.PictureBox()
        Me.opponent1 = New System.Windows.Forms.PictureBox()
        Me.player2 = New System.Windows.Forms.PictureBox()
        Me.player3 = New System.Windows.Forms.PictureBox()
        Me.opponent2 = New System.Windows.Forms.PictureBox()
        Me.opponent3 = New System.Windows.Forms.PictureBox()
        Me.plus1scorerace = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plus1scorerace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'player1
        '
        Me.player1.BackColor = System.Drawing.Color.MediumBlue
        Me.player1.Location = New System.Drawing.Point(12, 452)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(35, 30)
        Me.player1.TabIndex = 0
        Me.player1.TabStop = False
        '
        'opponent1
        '
        Me.opponent1.BackColor = System.Drawing.Color.Red
        Me.opponent1.Location = New System.Drawing.Point(12, 58)
        Me.opponent1.Name = "opponent1"
        Me.opponent1.Size = New System.Drawing.Size(35, 30)
        Me.opponent1.TabIndex = 1
        Me.opponent1.TabStop = False
        '
        'player2
        '
        Me.player2.BackColor = System.Drawing.Color.MediumBlue
        Me.player2.Location = New System.Drawing.Point(374, 452)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(35, 30)
        Me.player2.TabIndex = 2
        Me.player2.TabStop = False
        '
        'player3
        '
        Me.player3.BackColor = System.Drawing.Color.MediumBlue
        Me.player3.Location = New System.Drawing.Point(753, 452)
        Me.player3.Name = "player3"
        Me.player3.Size = New System.Drawing.Size(35, 30)
        Me.player3.TabIndex = 3
        Me.player3.TabStop = False
        '
        'opponent2
        '
        Me.opponent2.BackColor = System.Drawing.Color.Red
        Me.opponent2.Location = New System.Drawing.Point(374, 58)
        Me.opponent2.Name = "opponent2"
        Me.opponent2.Size = New System.Drawing.Size(35, 30)
        Me.opponent2.TabIndex = 4
        Me.opponent2.TabStop = False
        '
        'opponent3
        '
        Me.opponent3.BackColor = System.Drawing.Color.Red
        Me.opponent3.Location = New System.Drawing.Point(753, 58)
        Me.opponent3.Name = "opponent3"
        Me.opponent3.Size = New System.Drawing.Size(35, 30)
        Me.opponent3.TabIndex = 5
        Me.opponent3.TabStop = False
        '
        'plus1scorerace
        '
        Me.plus1scorerace.BackColor = System.Drawing.Color.Green
        Me.plus1scorerace.Location = New System.Drawing.Point(384, 249)
        Me.plus1scorerace.Name = "plus1scorerace"
        Me.plus1scorerace.Size = New System.Drawing.Size(15, 15)
        Me.plus1scorerace.TabIndex = 6
        Me.plus1scorerace.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 24)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(102, 17)
        Me.ToolStripStatusLabel1.Text = "Player's Crowns: 0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(124, 17)
        Me.ToolStripStatusLabel2.Text = "Opponent's Crowns: 0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.plus1scorerace)
        Me.Controls.Add(Me.opponent3)
        Me.Controls.Add(Me.opponent2)
        Me.Controls.Add(Me.player3)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.opponent1)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Crown Game"
        Me.TopMost = True
        CType(Me.player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plus1scorerace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents player1 As PictureBox
    Friend WithEvents opponent1 As PictureBox
    Friend WithEvents player2 As PictureBox
    Friend WithEvents player3 As PictureBox
    Friend WithEvents opponent2 As PictureBox
    Friend WithEvents opponent3 As PictureBox
    Friend WithEvents plus1scorerace As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
