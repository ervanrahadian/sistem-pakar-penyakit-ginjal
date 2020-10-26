Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox4.Checked = True Then
            TextBox1.Text = "Kanker Kandung Kemih"
            TextBox2.Text = "Penanganan berupa operasi, terapi biologi dan kemoterapi"
        End If
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox4.Checked = True And CheckBox5.Checked = True Then
            TextBox1.Text = "Sistitis"
            TextBox2.Text = "Minum banyak air dan pemberian antibiotik atropin"
        End If
        If CheckBox3.Checked = True And CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            TextBox1.Text = "Infeksi Saluran Kemih"
            TextBox2.Text = "Pemberian antibiotik penisilin"
        End If
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox6.Checked = True And CheckBox7.Checked = True Then
            TextBox1.Text = "Kanker Ginjal"
            TextBox2.Text = "Penanganan berupa teknik pengikisan (ablasi)"
        End If
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True And CheckBox7.Checked = True Then
            TextBox1.Text = "Gagal Ginjal Akut"
            TextBox2.Text = "Pemberian cairan Diuretik dan pembersihan darah"
        End If
    End Sub
    Sub Bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Bersih()
    End Sub
End Class
