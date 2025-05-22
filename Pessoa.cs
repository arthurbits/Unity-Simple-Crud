using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mono.Data.Sqlite;

public class Pessoa : MonoBehaviour
{
    public TMP_InputField inpNome;   
    public TMP_InputField inpBuscar;
    
    public TextMeshProUGUI lblList;    
    public TextMeshProUGUI lblNome;
    public TextMeshProUGUI lblId;

    private string dbName;

    void Start()
    {
        dbName = "URI=file:" + Application.dataPath + "/StreammingAssets/dbDesabrocha.db";
        Listar();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Adicionar()
    {
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO TESTE (NOME) VALUES (@nome)";
                cmd.Parameters.AddWithValue("@nome", inpNome.text);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }

    public void Listar()
    {
        lblList.text = "";
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM TESTE ORDER BY NOME";
                using (var reader = cmd.ExecuteReader())                 
                {
                    while (reader.Read())
                    {
                        lblList.text += reader["ID"].ToString() +" | " +reader["NOME"].ToString() + "\n";
                    }
                    reader.Close();
                }
            }
            con.Close();
        }

    }

    public void Alterar() 
    {
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "UPDATE TESTE SET NOME = @nome WHERE ID = @id";
                cmd.Parameters.AddWithValue("@nome", inpNome.text);
                cmd.Parameters.AddWithValue("@id", lblId.text);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
    
    public void Buscar()
    {
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM TESTE WHERE NOME LIKE @nome COLLATE NOCASE OR ID LIKE @id";
                cmd.Parameters.AddWithValue("@nome", inpBuscar.text);
                cmd.Parameters.AddWithValue("@id", inpBuscar.text);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lblId.text = reader["ID"].ToString();
                        lblNome.text = reader["NOME"].ToString();
                        inpNome.text = reader["NOME"].ToString();
                    }
                    reader.Close();
                }
            }
            con.Close();
        }
    }

    public void BtnSalvar()
    { 
        Adicionar();
        inpNome.text = "";
        Listar();
    }
    
    public void BtnAlterar()
    {
        Alterar();
        inpNome.text = "";
        lblId.text = "";
        lblNome.text = "";
        Listar();
    }
}