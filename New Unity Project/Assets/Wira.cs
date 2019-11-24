using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wira : MonoBehaviour
{
    public Text numb1txt;
    public Text numb2txt;
    public Text totaltxt;
    public int numb1;
    public int numb2;
    public int total;
    public Button Tambah;
    public Button Kurang;
    public Button Bagi;
    public Button Kali;
    public Button Clear;
    public Button Up1;
    public Button Down1;
    public Button Up2;
    public Button Down2;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
             

    }
    public void TambahAngka1()
    {
        numb1 = numb1 + 1;
       numb1txt.text = numb1.ToString();

    }
    public void KurangAngka1()
    {
        numb1 = numb1 - 1;
        numb1txt.text = numb1.ToString();

    }
    public void TambahAngka2()
    {
        numb2 = numb2 + 1;
        numb2txt.text = numb2.ToString();

    }
    public void KurangAngka2()
    {
        numb2 = numb2 - 1;
        numb2txt.text = numb2.ToString();

    }
    public void TambahButton()
    {
        total = numb1 + numb2;
        totaltxt.text = total.ToString();
    }
    public void KurangButton()
    {
        total = numb1 - numb2;
        totaltxt.text = total.ToString();
    }
    public void BagiButton()
    {
        total = numb1 / numb2;
        totaltxt.text = total.ToString();
    }
    public void KaliButton()
    {
        total = numb1 * numb2;
        totaltxt.text = total.ToString();
    }
    public void ClearButton()
    {
        numb1 = numb2 = total = 0;
        numb1txt.text = numb1.ToString();
        numb2txt.text = numb2.ToString();
        totaltxt.text = total.ToString();
    }
}
