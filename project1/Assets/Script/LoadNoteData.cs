using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LitJson;
using UnityEngine;

[System.Serializable]
public class NoteData
{
    public float NoteX { get; set; }
    public float NoteY { get; set; }
    public string NoteType { get; set; }


}
[System.Serializable]
public class NoteDataArray
{
    public NoteData[] Data { get; set; }
}

public class LoadNoteData : MonoBehaviour
{
    
    TextAsset XYdata;
    NoteDataArray NoteDataXY;

    public GameObject SNOTE;//하위에 이팩트 두기   // Notes1.cs  Effect스크립트
    public GameObject MNOTE;
    public GameObject PNOTE;
    public GameObject NoteParent;  //NoteParent GameObject 정렬을 위한 패런츠

    public float UserSpeed;

    void Awake()
    {
        UserSpeed = Option.UserSpeed;



        string DataName = SelectSingleton.SceneName;

        var XYdata = Resources.Load(DataName) as TextAsset;

        NoteDataArray NoteDataXY = JsonUtility.FromJson<NoteDataArray>(File.ReadAllText("Assets/Resources/data.json"));

        int count = NoteDataXY.Data.Length;
        for (int i = 0; i < count; i++)
        {
            if (NoteDataXY.Data[i].NoteType == "Forte")
            {
                Vector3 NoteVec = new Vector3(NoteDataXY.Data[i].NoteX, NoteDataXY.Data[i].NoteY * UserSpeed * NoteMove.Devel, 0);
                GameObject Note = Instantiate(SNOTE, NoteVec, Quaternion.identity) as GameObject;
                Note.transform.SetParent(NoteParent.transform);
                Note.gameObject.tag = "Strong";
                Note.transform.Translate(NoteVec);
            }

            if (NoteDataXY.Data[i].NoteType == "MezoPiano")
            {
                Vector3 NoteVec = new Vector3(NoteDataXY.Data[i].NoteX, NoteDataXY.Data[i].NoteY * UserSpeed * NoteMove.Devel, 0);
                GameObject Note = Instantiate(MNOTE, NoteVec, Quaternion.identity) as GameObject;
                Note.transform.SetParent(NoteParent.transform);
                Note.gameObject.tag = "MezoPiano";
                Note.transform.Translate(NoteVec);
            }

            if (NoteDataXY.Data[i].NoteType == "Piano")
            {
                Vector3 NoteVec = new Vector3(NoteDataXY.Data[i].NoteX, NoteDataXY.Data[i].NoteY * UserSpeed * NoteMove.Devel, 0);
                GameObject Note = Instantiate(PNOTE, NoteVec, Quaternion.identity) as GameObject;
                Note.transform.SetParent(NoteParent.transform);
                Note.gameObject.tag = "Piano";
                Note.transform.Translate(NoteVec);
            }
        }

    }
}




