using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluacion : MonoBehaviour
{
    public float Taxis;
    public float DiasTot;
    public float DiasDeLluvia;
    float dias;
    float CostoDia;
    float CostoLluvia;
    float Costo;
    float TotalDias;
    float TotalLluvia;

    // Start is called before the first frame update
    void Start() {
        
        dias = DiasTot - DiasDeLluvia;
        CostoDia = Taxis *(6*130);
        TotalDias = CostoDia * dias;
        CostoLluvia = Taxis * (7 * 130);
        TotalLluvia = CostoLluvia * DiasDeLluvia;
        Costo = TotalDias + TotalLluvia;


        if (DiasTot < 5)
        {
            Debug.Log("la cantidad de dias debe ser mayor a 5");
        }

        else if (DiasDeLluvia > DiasTot)
        {
            Debug.Log("la cantidad de dias de lluvia no puede ser mayor a la cantidad de dias totales");
        }

        else if (DiasTot >= 5)
        {
            Debug.Log("una flota de " + Taxis + " unidades trabajando durante " + DiasTot + "dias implica un gasto de $" + Costo + " en terminos de combustible");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
