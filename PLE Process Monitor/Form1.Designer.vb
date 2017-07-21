<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLEProcessMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLEProcessMonitor))
        Me.BtnAzyra = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAzyra = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLastAzyra = New System.Windows.Forms.Label()
        Me.lblNextAzyra = New System.Windows.Forms.Label()
        Me.BtnTimedMonitor = New System.Windows.Forms.Button()
        Me.lblNextTimedData = New System.Windows.Forms.Label()
        Me.lblLastTimedData = New System.Windows.Forms.Label()
        Me.lblTimedMonitor = New System.Windows.Forms.Label()
        Me.tblReportingTimes = New System.Data.DataSet()
        Me.tblReport = New System.Data.DataTable()
        Me.colProcess = New System.Data.DataColumn()
        Me.colTime = New System.Data.DataColumn()
        CType(Me.tblReportingTimes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAzyra
        '
        Me.BtnAzyra.BackColor = System.Drawing.Color.DarkRed
        Me.BtnAzyra.FlatAppearance.BorderSize = 0
        Me.BtnAzyra.ForeColor = System.Drawing.Color.Transparent
        Me.BtnAzyra.Location = New System.Drawing.Point(33, 57)
        Me.BtnAzyra.Name = "BtnAzyra"
        Me.BtnAzyra.Size = New System.Drawing.Size(40, 40)
        Me.BtnAzyra.TabIndex = 0
        Me.BtnAzyra.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(29, 27)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 20)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Status"
        '
        'lblAzyra
        '
        Me.lblAzyra.AutoSize = True
        Me.lblAzyra.Location = New System.Drawing.Point(79, 71)
        Me.lblAzyra.Name = "lblAzyra"
        Me.lblAzyra.Size = New System.Drawing.Size(38, 13)
        Me.lblAzyra.TabIndex = 2
        Me.lblAzyra.Text = "Azyra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(255, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Last Checked"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(506, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Next Check"
        '
        'lblLastAzyra
        '
        Me.lblLastAzyra.AutoSize = True
        Me.lblLastAzyra.Location = New System.Drawing.Point(256, 71)
        Me.lblLastAzyra.Name = "lblLastAzyra"
        Me.lblLastAzyra.Size = New System.Drawing.Size(38, 13)
        Me.lblLastAzyra.TabIndex = 5
        Me.lblLastAzyra.Text = "Azyra"
        '
        'lblNextAzyra
        '
        Me.lblNextAzyra.AutoSize = True
        Me.lblNextAzyra.Location = New System.Drawing.Point(507, 71)
        Me.lblNextAzyra.Name = "lblNextAzyra"
        Me.lblNextAzyra.Size = New System.Drawing.Size(38, 13)
        Me.lblNextAzyra.TabIndex = 5
        Me.lblNextAzyra.Text = "Azyra"
        '
        'BtnTimedMonitor
        '
        Me.BtnTimedMonitor.BackColor = System.Drawing.Color.DarkRed
        Me.BtnTimedMonitor.FlatAppearance.BorderSize = 0
        Me.BtnTimedMonitor.ForeColor = System.Drawing.Color.Transparent
        Me.BtnTimedMonitor.Location = New System.Drawing.Point(33, 116)
        Me.BtnTimedMonitor.Name = "BtnTimedMonitor"
        Me.BtnTimedMonitor.Size = New System.Drawing.Size(40, 40)
        Me.BtnTimedMonitor.TabIndex = 6
        Me.BtnTimedMonitor.UseVisualStyleBackColor = False
        '
        'lblNextTimedData
        '
        Me.lblNextTimedData.AutoSize = True
        Me.lblNextTimedData.Location = New System.Drawing.Point(507, 130)
        Me.lblNextTimedData.Name = "lblNextTimedData"
        Me.lblNextTimedData.Size = New System.Drawing.Size(109, 13)
        Me.lblNextTimedData.TabIndex = 9
        Me.lblNextTimedData.Text = "TimedMonitorNext"
        '
        'lblLastTimedData
        '
        Me.lblLastTimedData.AutoSize = True
        Me.lblLastTimedData.Location = New System.Drawing.Point(256, 130)
        Me.lblLastTimedData.Name = "lblLastTimedData"
        Me.lblLastTimedData.Size = New System.Drawing.Size(107, 13)
        Me.lblLastTimedData.TabIndex = 8
        Me.lblLastTimedData.Text = "TimedMonitorLast"
        '
        'lblTimedMonitor
        '
        Me.lblTimedMonitor.AutoSize = True
        Me.lblTimedMonitor.Location = New System.Drawing.Point(79, 130)
        Me.lblTimedMonitor.Name = "lblTimedMonitor"
        Me.lblTimedMonitor.Size = New System.Drawing.Size(118, 13)
        Me.lblTimedMonitor.TabIndex = 7
        Me.lblTimedMonitor.Text = "Timed Monitor Data"
        '
        'tblReportingTimes
        '
        Me.tblReportingTimes.DataSetName = "ReportingTimes"
        Me.tblReportingTimes.Tables.AddRange(New System.Data.DataTable() {Me.tblReport})
        '
        'tblReport
        '
        Me.tblReport.Columns.AddRange(New System.Data.DataColumn() {Me.colProcess, Me.colTime})
        Me.tblReport.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ProcessName"}, True)})
        Me.tblReport.PrimaryKey = New System.Data.DataColumn() {Me.colProcess}
        Me.tblReport.TableName = "ReportingTimes"
        '
        'colProcess
        '
        Me.colProcess.AllowDBNull = False
        Me.colProcess.ColumnName = "ProcessName"
        '
        'colTime
        '
        Me.colTime.AllowDBNull = False
        Me.colTime.ColumnName = "NextRun"
        Me.colTime.DataType = GetType(Date)
        '
        'PLEProcessMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(736, 493)
        Me.Controls.Add(Me.lblNextTimedData)
        Me.Controls.Add(Me.lblLastTimedData)
        Me.Controls.Add(Me.lblTimedMonitor)
        Me.Controls.Add(Me.BtnTimedMonitor)
        Me.Controls.Add(Me.lblNextAzyra)
        Me.Controls.Add(Me.lblLastAzyra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAzyra)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.BtnAzyra)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PLEProcessMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLE Process Monitor"
        CType(Me.tblReportingTimes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAzyra As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblAzyra As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLastAzyra As Label
    Friend WithEvents lblNextAzyra As Label
    Friend WithEvents BtnTimedMonitor As Button
    Friend WithEvents lblNextTimedData As Label
    Friend WithEvents lblLastTimedData As Label
    Friend WithEvents lblTimedMonitor As Label
    Friend WithEvents tblReportingTimes As DataSet
    Friend WithEvents tblReport As DataTable
    Friend WithEvents colProcess As DataColumn
    Friend WithEvents colTime As DataColumn
End Class
