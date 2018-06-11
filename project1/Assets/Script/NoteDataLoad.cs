using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LitJson;
using UnityEngine;




[System.Serializable]
public class NoteDataLoad : MonoBehaviour
{

    public LitJson.JsonData jsonData;
    public JsonData NoteDataXY;

    public GameObject SNOTE;//하위에 이팩트 두기   // Notes1.cs  Effect스크립트
    public GameObject MNOTE;
    public GameObject PNOTE;
    public GameObject NoteParent;  //NoteParent GameObject 정렬을 위한 패런츠

    public float UserSpeed;

    void Awake()
    {


        UserSpeed = Option.UserSpeed;

        string DataName = SelectSingleton.SceneName;

        TextAsset textAsset = (TextAsset)Resources.Load("data", typeof(TextAsset));

        string JsonText = textAsset.text;

        LitJson.JsonData jsonData = LitJson.JsonMapper.ToObject(JsonText);
        LitJson.JsonData NoteDataXY = jsonData["Data"];

        try {
            for (int i = 0; i < 200; i++)
            {
                JsonData JSdata = NoteDataXY[i];

                double NoteX = Convert.ToDouble(JSdata["NoteX"].ToString());
                double NoteY = Convert.ToDouble(JSdata["NoteY"].ToString());

                if (JSdata["NoteType"].ToString() == "Forte")
                {
                    Vector3 NoteVec = new Vector3((float)NoteX, (float)NoteY * UserSpeed + NoteMove.Devel, -1);
                    GameObject Note = Instantiate(SNOTE, NoteVec, Quaternion.identity) as GameObject;
                    Note.gameObject.tag = "Forte";
                    Note.transform.Translate(NoteVec);
                }

                if (JSdata["NoteType"].ToString() == "MezoPiano")
                {
                    Vector3 NoteVec = new Vector3((float)NoteX, (float)NoteY * UserSpeed * NoteMove.Devel, 0);
                    GameObject Note = Instantiate(MNOTE, NoteVec, Quaternion.identity) as GameObject;
                    Note.transform.SetParent(NoteParent.transform);
                    Note.gameObject.tag = "MezoPiano";
                    Note.transform.Translate(NoteVec);
                }

                if (JSdata["NoteType"].ToString() == "Piano")
                {
                    Vector3 NoteVec = new Vector3((float)NoteX, (float)NoteY * UserSpeed * NoteMove.Devel, 0);
                    GameObject Note = Instantiate(PNOTE, NoteVec, Quaternion.identity) as GameObject;
                    Note.transform.SetParent(NoteParent.transform);
                    Note.gameObject.tag = "Piano";
                    Note.transform.Translate(NoteVec);
                }
            }
        }
        catch { }
    }
}
