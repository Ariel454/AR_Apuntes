namespace AR_Apuntes.Views;

public partial class AR_NotePage : ContentPage
{
    string AR_fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public AR_NotePage()
	{
		InitializeComponent();

        if (File.Exists(AR_fileName))
            AR_TextEditor.Text = File.ReadAllText(AR_fileName);

    }

    private void AR_GuardarBoton_Clicked(object sender, EventArgs e) 
    {
        //Guarda el archivo
        File.WriteAllText(AR_fileName, AR_TextEditor.Text);

    }

    private void AR_BorrarBoton_Clicked(object sender, EventArgs e)
    {
    
        //Borra el archivo
        if (File.Exists(AR_fileName))
            File.Delete(AR_fileName);

        AR_TextEditor.Text = string.Empty;
    }

}