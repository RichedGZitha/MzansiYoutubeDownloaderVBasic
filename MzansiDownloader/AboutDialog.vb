' Author: Richard Zitha 
' Email: equitekconsulting@gmail.com
' Class Name: AboutDialog


Public Class AboutDialog


    ' Visit a link: Official website.
    Private Sub lblWebsiteHyperlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblWebsiteHyperlink.LinkClicked
        lblWebsiteHyperlink.LinkVisited = True

        ' Open this link on the device's default browser.
        System.Diagnostics.Process.Start("http://equitek.herokuapp.com")
    End Sub

End Class