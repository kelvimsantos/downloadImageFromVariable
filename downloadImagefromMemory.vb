Imports System.Net
Imports System.Drawing

Module Module1
    Sub Main()
        ' URL da imagem que deseja baixar
        Dim url As String = "https://exemplo.com/imagem.jpg"

        ' Baixar a imagem e salvá-la em um arquivo temporário
        Dim client As New WebClient()
        Dim tempFile As String = IO.Path.GetTempFileName()
        client.DownloadFile(url, tempFile)

        ' Carregar a imagem do arquivo temporário
        Dim image As Image = Image.FromFile(tempFile)

        ' Converter a imagem em uma variável
        Dim imageVariable As Object = image

        ' Exibir informações sobre a imagem
        Console.WriteLine("Dimensões da imagem: " & image.Width & " x " & image.Height)

        ' Realizar outras operações com a imagem...

        ' Excluir o arquivo temporário
        IO.File.Delete(tempFile)

        Console.ReadLine()
    End Sub
End Module
