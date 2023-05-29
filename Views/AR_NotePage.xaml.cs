namespace AR_Apuntes.Views;

public partial class AR_NotePage : ContentPage
{
    string AR_fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public AR_NotePage()
	{
		InitializeComponent();

        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        AR_CargarNota(Path.Combine(appDataPath, randomFileName));

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

    private void AR_CargarNota(string AR_fileName)
    { 
        Models.AR_Note noteModel = new Models.AR_Note();
        noteModel.Filename = AR_fileName;

        if (File.Exists(AR_fileName))
        { 
            noteModel.Date = File.GetCreationTime(AR_fileName);
            noteModel.Text = File.ReadAllText(AR_fileName);
        }

        BindingContext = noteModel;
    }

}