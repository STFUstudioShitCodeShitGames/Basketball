using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(BoxCollider2D))]
public class Orgi: MonoBehaviour
{
    private BoxCollider2D _npoo;

    private RectTransform Kulli => _trihg == null ? GetComponent<RectTransform>() : _trihg;
    

    private RectTransform _trihg;

    private void OnRectTransformDimensionsChange()
    {
        Joopplk();
    }

    private void Joopplk()
    {
        Hllop.size = Kulli.rect.size;
        Hllop.offset = Kulli.rect.center;
    }
    
    public BoxCollider2D Hllop => _npoo == null ? GetComponent<BoxCollider2D>() : _npoo;
    
    private void OnEnable()
    {
        Joopplk();
    }


}
