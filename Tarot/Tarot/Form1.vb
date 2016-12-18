Public Class Form1
    Private karta1 As Integer
    Private karta2 As Integer
    Private karta3 As Integer
    Private karta4 As Integer
    Private koubi As Integer = 0
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If koubi = 1 Then
            If karta3 = 1 Then
                MsgBox(onoma.Text & " ,αποφύγετε ξαφνικές κινήσεις που μπορεί να μετανιώσετε. Υπάρχει το ενδεχόμενο να σταματήσετε κάποια εργασία λόγω κακής διαχείρισής της από μέρους σας. ")

            ElseIf karta3 = 2 Then
                MsgBox(onoma.Text & " ,πρέπει να είστε πολύ προσεκτικοί με τα άτομα που βρίσκονται κοντά σας, ιδιαίτερα με τις γυναίκες γιατί ίσως κάποια από αυτές εποφθαλμιά τη θέση σας. Μην πιστεύετε ό,τι σας λένε και κινηθείτε με επιφύλαξη. ")
            ElseIf karta3 = 3 Then
                MsgBox(onoma.Text & " ,είναι πολύ πιθανή μια απώλεια χρημάτων ή υλικών αγαθών και θα πρέπει να αποφύγετε βιαστικές κινήσεις. ")
            ElseIf karta3 = 4 Then
                MsgBox(onoma.Text & " ,θα βρεθούμε αντιμέτωποι με ξαφνικά εμπόδια που θα μας δυσκολέψουν στην πορεία μας. Αντιμετωπίστε την απροθυμία σας γιατί μπορεί να σας βλάψει στο τέλος. ")
            ElseIf karta3 = 5 Then
                MsgBox(onoma.Text & " ,βρισκόμαστε εγκλωβισμένοι σε κάποια σχέση, πράγμα που δε θέλουμε να παραδεχτούμε. Ήρθε η ώρα να φέρουμε τα πάνω κάτω στη σχέση αυτή για να μπορέσουμε να τακτοποιήσουμε την κατάσταση χωρίς να πληγωθούμε.")
            ElseIf karta3 = 6 Then
                MsgBox(onoma.Text & " ,προειδοποιεί για ενδεχόμενη απιστία που υπάρχει στη σχέση μας. Αν είμαστε αδέσμευτοι, καλό θα είναι να είμαστε πολύ προσεκτικοί στο ξεκίνημα μιας νέας σχέσης, γιατί ίσως να μην είναι αντάξια των προσδοκιών μας. ")
            ElseIf karta3 = 7 Then
                MsgBox(onoma.Text & " ,αναλωνόμαστε χωρίς λόγο σε πράγματα που δεν αξίζουν. Πρέπει να επικεντρωθούμε σε ό,τι αξίζει πραγματικά και επίσης να ελέγξουμε την υπέρμερτη φιλοδοξία μας γιατί δε θα μας βγει σε καλό. ")
            ElseIf karta3 = 8 Then
                MsgBox(onoma.Text & " ,μας έχουν επηρεάσει οι φόβοι μας, με αποτέλεσμα να έχουμε κλειστεί στον εαυτό μας. Η κατάσταση στην οποία βρισκόμαστε δε μας ωφελεί και έχουμε πολλές αμφιβολίες που μας κρατάνε πίσω. Πρέπει να δείξουμε θάρρος για να ξεπεράσουμε τις δυσκολίες. ")
            ElseIf karta3 = 9 Then
                MsgBox(onoma.Text & " ,καλό θα είναι να ακούσουμε λίγο και τις απόψεις των άλλων και να σταματήσουμε να κάνουμε συνεχώς αυτό που εμείς θεωρούμε σωστό. Μάλλον μόνοι μας δυσκολεύουμε την κατάσταση γιατί αρνούμαστε να τη δούμε ξακάθαρα. Ίσως κάποιο πρόσωπο θα εισέλθει στη ζωή μας, όχι τόσο σε ρόλο δασκάλου, αλλά μέντορα. Δε θα μας δώσει έτοιμες λύσεις, θα μας καθοδηγήσει όμως στο να τις βρούμε μόνοι μας. ")
            ElseIf karta3 = 10 Then
                MsgBox(onoma.Text & " ,ανάλογα με την κατάσταση στην οποία βρισκόμαστε, θα περάσουμε για λίγο στην αντίθετή της. ")
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If koubi = 0 Then
            If onoma.Text = "" Then
                MsgBox("Δωσε ονομα")
            Else
                Button1.Text = ("Αρχησε Ξανα")
                'First Card
                Dim tyxaio1 As Random
                Dim number1 As Integer
                tyxaio1 = New Random
                number1 = tyxaio1.Next(1, 10)
                If number1 = 1 Then
                    PictureBox1.Image = My.Resources.the_magician

                ElseIf number1 = 2 Then
                    PictureBox1.Image = My.Resources.the_high_priestess

                ElseIf number1 = 3 Then
                    PictureBox1.Image = My.Resources.the_empress

                ElseIf number1 = 4 Then
                    PictureBox1.Image = My.Resources.the_emperor

                ElseIf number1 = 5 Then
                    PictureBox1.Image = My.Resources.the_hierophant

                ElseIf number1 = 6 Then
                    PictureBox1.Image = My.Resources.the_lover

                ElseIf number1 = 7 Then
                    PictureBox1.Image = My.Resources.the_chariot

                ElseIf number1 = 8 Then
                    PictureBox1.Image = My.Resources.the_strength

                ElseIf number1 = 9 Then
                    PictureBox1.Image = My.Resources.the_hermit

                ElseIf number1 = 10 Then
                    PictureBox1.Image = My.Resources.the_wheel
                End If
                karta1 = number1



                'Second  Card
                Dim tyxaio2 As Random
                Dim number2 As Integer
                Do
                    tyxaio2 = New Random
                    number2 = tyxaio2.Next(1, 10)

                Loop Until number2 <> number1
                If number2 = 1 Then
                    PictureBox2.Image = My.Resources.the_magician

                ElseIf number2 = 2 Then
                    PictureBox2.Image = My.Resources.the_high_priestess

                ElseIf number2 = 3 Then
                    PictureBox2.Image = My.Resources.the_empress

                ElseIf number2 = 4 Then
                    PictureBox2.Image = My.Resources.the_emperor

                ElseIf number2 = 5 Then
                    PictureBox2.Image = My.Resources.the_hierophant

                ElseIf number2 = 6 Then
                    PictureBox2.Image = My.Resources.the_lover

                ElseIf number2 = 7 Then
                    PictureBox2.Image = My.Resources.the_chariot

                ElseIf number2 = 8 Then
                    PictureBox2.Image = My.Resources.the_strength

                ElseIf number2 = 9 Then
                    PictureBox2.Image = My.Resources.the_hermit

                ElseIf number2 = 10 Then
                    PictureBox2.Image = My.Resources.the_wheel
                End If
                karta2 = number2


                'Third  Card
                Dim tyxaio3 As Random
                Dim number3 As Integer
                Do
                    tyxaio3 = New Random
                    number3 = tyxaio3.Next(1, 10)

                Loop Until number3 <> number1 And number3 <> number2
                If number3 = 1 Then
                    PictureBox3.Image = My.Resources.the_magician

                ElseIf number3 = 2 Then
                    PictureBox3.Image = My.Resources.the_high_priestess

                ElseIf number3 = 3 Then
                    PictureBox3.Image = My.Resources.the_empress

                ElseIf number3 = 4 Then
                    PictureBox3.Image = My.Resources.the_emperor

                ElseIf number3 = 5 Then
                    PictureBox3.Image = My.Resources.the_hierophant

                ElseIf number3 = 6 Then
                    PictureBox3.Image = My.Resources.the_lover

                ElseIf number3 = 7 Then
                    PictureBox3.Image = My.Resources.the_chariot

                ElseIf number3 = 8 Then
                    PictureBox3.Image = My.Resources.the_strength

                ElseIf number3 = 9 Then
                    PictureBox3.Image = My.Resources.the_hermit

                ElseIf number3 = 10 Then
                    PictureBox3.Image = My.Resources.the_wheel
                End If
                karta3 = number3

                'Fourth  Card
                Dim tyxaio4 As Random
                Dim number4 As Integer
                Do
                    tyxaio4 = New Random
                    number4 = tyxaio4.Next(1, 10)

                Loop Until number4 <> number1 And number4 <> number2 And number4 <> number3
                If number4 = 1 Then
                    PictureBox4.Image = My.Resources.the_magician

                ElseIf number4 = 2 Then
                    PictureBox4.Image = My.Resources.the_high_priestess

                ElseIf number4 = 3 Then
                    PictureBox4.Image = My.Resources.the_empress

                ElseIf number4 = 4 Then
                    PictureBox4.Image = My.Resources.the_emperor

                ElseIf number4 = 5 Then
                    PictureBox4.Image = My.Resources.the_hierophant

                ElseIf number4 = 6 Then
                    PictureBox4.Image = My.Resources.the_lover

                ElseIf number4 = 7 Then
                    PictureBox4.Image = My.Resources.the_chariot

                ElseIf number4 = 8 Then
                    PictureBox4.Image = My.Resources.the_strength

                ElseIf number4 = 9 Then
                    PictureBox4.Image = My.Resources.the_hermit

                ElseIf number4 = 10 Then
                    PictureBox4.Image = My.Resources.the_wheel
                End If
                karta4 = number4
                koubi = 1
            End If
        ElseIf koubi = 1 Then
            Button1.Text = ("Μαθε το μελλον σου")
            PictureBox1.Image = My.Resources._41d8375f3237702fed8b274ae68306ab
            PictureBox2.Image = My.Resources._41d8375f3237702fed8b274ae68306ab
            PictureBox3.Image = My.Resources._41d8375f3237702fed8b274ae68306ab
            PictureBox4.Image = My.Resources._41d8375f3237702fed8b274ae68306ab
            koubi = 0
        End If







    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If koubi = 1 Then
            If karta1 = 1 Then
                MsgBox(onoma.Text & " ,αποφύγετε ξαφνικές κινήσεις που μπορεί να μετανιώσετε. Υπάρχει το ενδεχόμενο να σταματήσετε κάποια εργασία λόγω κακής διαχείρισής της από μέρους σας. ")

            ElseIf karta1 = 2 Then
                MsgBox(onoma.Text & " ,πρέπει να είστε πολύ προσεκτικοί με τα άτομα που βρίσκονται κοντά σας, ιδιαίτερα με τις γυναίκες γιατί ίσως κάποια από αυτές εποφθαλμιά τη θέση σας. Μην πιστεύετε ό,τι σας λένε και κινηθείτε με επιφύλαξη. ")
            ElseIf karta1 = 3 Then
                MsgBox(onoma.Text & " ,είναι πολύ πιθανή μια απώλεια χρημάτων ή υλικών αγαθών και θα πρέπει να αποφύγετε βιαστικές κινήσεις. ")
            ElseIf karta1 = 4 Then
                MsgBox(onoma.Text & " ,θα βρεθούμε αντιμέτωποι με ξαφνικά εμπόδια που θα μας δυσκολέψουν στην πορεία μας. Αντιμετωπίστε την απροθυμία σας γιατί μπορεί να σας βλάψει στο τέλος. ")
            ElseIf karta1 = 5 Then
                MsgBox(onoma.Text & " ,βρισκόμαστε εγκλωβισμένοι σε κάποια σχέση, πράγμα που δε θέλουμε να παραδεχτούμε. Ήρθε η ώρα να φέρουμε τα πάνω κάτω στη σχέση αυτή για να μπορέσουμε να τακτοποιήσουμε την κατάσταση χωρίς να πληγωθούμε.")
            ElseIf karta1 = 6 Then
                MsgBox(onoma.Text & " ,προειδοποιεί για ενδεχόμενη απιστία που υπάρχει στη σχέση μας. Αν είμαστε αδέσμευτοι, καλό θα είναι να είμαστε πολύ προσεκτικοί στο ξεκίνημα μιας νέας σχέσης, γιατί ίσως να μην είναι αντάξια των προσδοκιών μας. ")
            ElseIf karta1 = 7 Then
                MsgBox(onoma.Text & " ,αναλωνόμαστε χωρίς λόγο σε πράγματα που δεν αξίζουν. Πρέπει να επικεντρωθούμε σε ό,τι αξίζει πραγματικά και επίσης να ελέγξουμε την υπέρμερτη φιλοδοξία μας γιατί δε θα μας βγει σε καλό. ")
            ElseIf karta1 = 8 Then
                MsgBox(onoma.Text & " ,μας έχουν επηρεάσει οι φόβοι μας, με αποτέλεσμα να έχουμε κλειστεί στον εαυτό μας. Η κατάσταση στην οποία βρισκόμαστε δε μας ωφελεί και έχουμε πολλές αμφιβολίες που μας κρατάνε πίσω. Πρέπει να δείξουμε θάρρος για να ξεπεράσουμε τις δυσκολίες. ")
            ElseIf karta1 = 9 Then
                MsgBox(onoma.Text & " ,καλό θα είναι να ακούσουμε λίγο και τις απόψεις των άλλων και να σταματήσουμε να κάνουμε συνεχώς αυτό που εμείς θεωρούμε σωστό. Μάλλον μόνοι μας δυσκολεύουμε την κατάσταση γιατί αρνούμαστε να τη δούμε ξακάθαρα. Ίσως κάποιο πρόσωπο θα εισέλθει στη ζωή μας, όχι τόσο σε ρόλο δασκάλου, αλλά μέντορα. Δε θα μας δώσει έτοιμες λύσεις, θα μας καθοδηγήσει όμως στο να τις βρούμε μόνοι μας. ")
            ElseIf karta1 = 10 Then
                MsgBox(onoma.Text & " ,ανάλογα με την κατάσταση στην οποία βρισκόμαστε, θα περάσουμε για λίγο στην αντίθετή της. ")

            End If
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If koubi = 1 Then
            If karta2 = 1 Then
                MsgBox(onoma.Text & " ,αποφύγετε ξαφνικές κινήσεις που μπορεί να μετανιώσετε. Υπάρχει το ενδεχόμενο να σταματήσετε κάποια εργασία λόγω κακής διαχείρισής της από μέρους σας. ")

            ElseIf karta2 = 2 Then
                MsgBox(onoma.Text & " ,πρέπει να είστε πολύ προσεκτικοί με τα άτομα που βρίσκονται κοντά σας, ιδιαίτερα με τις γυναίκες γιατί ίσως κάποια από αυτές εποφθαλμιά τη θέση σας. Μην πιστεύετε ό,τι σας λένε και κινηθείτε με επιφύλαξη. ")
            ElseIf karta2 = 3 Then
                MsgBox(onoma.Text & " ,είναι πολύ πιθανή μια απώλεια χρημάτων ή υλικών αγαθών και θα πρέπει να αποφύγετε βιαστικές κινήσεις. ")
            ElseIf karta2 = 4 Then
                MsgBox(onoma.Text & " ,θα βρεθούμε αντιμέτωποι με ξαφνικά εμπόδια που θα μας δυσκολέψουν στην πορεία μας. Αντιμετωπίστε την απροθυμία σας γιατί μπορεί να σας βλάψει στο τέλος. ")
            ElseIf karta2 = 5 Then
                MsgBox(onoma.Text & " ,βρισκόμαστε εγκλωβισμένοι σε κάποια σχέση, πράγμα που δε θέλουμε να παραδεχτούμε. Ήρθε η ώρα να φέρουμε τα πάνω κάτω στη σχέση αυτή για να μπορέσουμε να τακτοποιήσουμε την κατάσταση χωρίς να πληγωθούμε.")
            ElseIf karta2 = 6 Then
                MsgBox(onoma.Text & " ,προειδοποιεί για ενδεχόμενη απιστία που υπάρχει στη σχέση μας. Αν είμαστε αδέσμευτοι, καλό θα είναι να είμαστε πολύ προσεκτικοί στο ξεκίνημα μιας νέας σχέσης, γιατί ίσως να μην είναι αντάξια των προσδοκιών μας. ")
            ElseIf karta2 = 7 Then
                MsgBox(onoma.Text & " ,αναλωνόμαστε χωρίς λόγο σε πράγματα που δεν αξίζουν. Πρέπει να επικεντρωθούμε σε ό,τι αξίζει πραγματικά και επίσης να ελέγξουμε την υπέρμερτη φιλοδοξία μας γιατί δε θα μας βγει σε καλό. ")
            ElseIf karta2 = 8 Then
                MsgBox(onoma.Text & " ,μας έχουν επηρεάσει οι φόβοι μας, με αποτέλεσμα να έχουμε κλειστεί στον εαυτό μας. Η κατάσταση στην οποία βρισκόμαστε δε μας ωφελεί και έχουμε πολλές αμφιβολίες που μας κρατάνε πίσω. Πρέπει να δείξουμε θάρρος για να ξεπεράσουμε τις δυσκολίες. ")
            ElseIf karta2 = 9 Then
                MsgBox(onoma.Text & " ,καλό θα είναι να ακούσουμε λίγο και τις απόψεις των άλλων και να σταματήσουμε να κάνουμε συνεχώς αυτό που εμείς θεωρούμε σωστό. Μάλλον μόνοι μας δυσκολεύουμε την κατάσταση γιατί αρνούμαστε να τη δούμε ξακάθαρα. Ίσως κάποιο πρόσωπο θα εισέλθει στη ζωή μας, όχι τόσο σε ρόλο δασκάλου, αλλά μέντορα. Δε θα μας δώσει έτοιμες λύσεις, θα μας καθοδηγήσει όμως στο να τις βρούμε μόνοι μας. ")
            ElseIf karta2 = 10 Then
                MsgBox(onoma.Text & " ,ανάλογα με την κατάσταση στην οποία βρισκόμαστε, θα περάσουμε για λίγο στην αντίθετή της. ")
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If koubi = 1 Then
            If karta4 = 1 Then
                MsgBox(onoma.Text & " ,αποφύγετε ξαφνικές κινήσεις που μπορεί να μετανιώσετε. Υπάρχει το ενδεχόμενο να σταματήσετε κάποια εργασία λόγω κακής διαχείρισής της από μέρους σας. ")

            ElseIf karta4 = 2 Then
                MsgBox(onoma.Text & " ,πρέπει να είστε πολύ προσεκτικοί με τα άτομα που βρίσκονται κοντά σας, ιδιαίτερα με τις γυναίκες γιατί ίσως κάποια από αυτές εποφθαλμιά τη θέση σας. Μην πιστεύετε ό,τι σας λένε και κινηθείτε με επιφύλαξη. ")
            ElseIf karta4 = 3 Then
                MsgBox(onoma.Text & " ,είναι πολύ πιθανή μια απώλεια χρημάτων ή υλικών αγαθών και θα πρέπει να αποφύγετε βιαστικές κινήσεις. ")
            ElseIf karta4 = 4 Then
                MsgBox(onoma.Text & " ,θα βρεθούμε αντιμέτωποι με ξαφνικά εμπόδια που θα μας δυσκολέψουν στην πορεία μας. Αντιμετωπίστε την απροθυμία σας γιατί μπορεί να σας βλάψει στο τέλος. ")
            ElseIf karta4 = 5 Then
                MsgBox(onoma.Text & " ,βρισκόμαστε εγκλωβισμένοι σε κάποια σχέση, πράγμα που δε θέλουμε να παραδεχτούμε. Ήρθε η ώρα να φέρουμε τα πάνω κάτω στη σχέση αυτή για να μπορέσουμε να τακτοποιήσουμε την κατάσταση χωρίς να πληγωθούμε.")
            ElseIf karta4 = 6 Then
                MsgBox(onoma.Text & " ,προειδοποιεί για ενδεχόμενη απιστία που υπάρχει στη σχέση μας. Αν είμαστε αδέσμευτοι, καλό θα είναι να είμαστε πολύ προσεκτικοί στο ξεκίνημα μιας νέας σχέσης, γιατί ίσως να μην είναι αντάξια των προσδοκιών μας. ")
            ElseIf karta4 = 7 Then
                MsgBox(onoma.Text & " ,αναλωνόμαστε χωρίς λόγο σε πράγματα που δεν αξίζουν. Πρέπει να επικεντρωθούμε σε ό,τι αξίζει πραγματικά και επίσης να ελέγξουμε την υπέρμερτη φιλοδοξία μας γιατί δε θα μας βγει σε καλό. ")
            ElseIf karta4 = 8 Then
                MsgBox(onoma.Text & " ,μας έχουν επηρεάσει οι φόβοι μας, με αποτέλεσμα να έχουμε κλειστεί στον εαυτό μας. Η κατάσταση στην οποία βρισκόμαστε δε μας ωφελεί και έχουμε πολλές αμφιβολίες που μας κρατάνε πίσω. Πρέπει να δείξουμε θάρρος για να ξεπεράσουμε τις δυσκολίες. ")
            ElseIf karta4 = 9 Then
                MsgBox(onoma.Text & " ,καλό θα είναι να ακούσουμε λίγο και τις απόψεις των άλλων και να σταματήσουμε να κάνουμε συνεχώς αυτό που εμείς θεωρούμε σωστό. Μάλλον μόνοι μας δυσκολεύουμε την κατάσταση γιατί αρνούμαστε να τη δούμε ξακάθαρα. Ίσως κάποιο πρόσωπο θα εισέλθει στη ζωή μας, όχι τόσο σε ρόλο δασκάλου, αλλά μέντορα. Δε θα μας δώσει έτοιμες λύσεις, θα μας καθοδηγήσει όμως στο να τις βρούμε μόνοι μας. ")
            ElseIf karta4 = 10 Then
                MsgBox(onoma.Text & " ,ανάλογα με την κατάσταση στην οποία βρισκόμαστε, θα περάσουμε για λίγο στην αντίθετή της. ")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("*Δωστε Ονομα" & vbNewLine & "* Κσεκιναται πατωντας Μαθε το μελλον σου" & vbNewLine & "*Αφοτου εμφανιστουν τα φυλα,πατατε πανω στις καρτες,ωστε να μαθεται την ερμηνια της καρτας" & vbNewLine & "*Για να ξαναξεκινισεται,πατηστε Αρχηστε Ξανα.")
    End Sub
End Class
