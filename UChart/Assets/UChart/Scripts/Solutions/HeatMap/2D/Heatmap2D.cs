
using UnityEngine;
using UnityEngine.UI;

namespace UChart.HeatMap
{
    public class Heatmap2D : Image
    {
        private Material instanceMaterial;
        private static Sprite m_emptySprite;
        private Sprite emptySprite
        {
            get
            {
                if(null == m_emptySprite)
                    m_emptySprite = OnePixelWhiteSprite();
                return m_emptySprite;
            }
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            this.Init();
        }

        private void Init()
        {
            this.sprite = emptySprite;
            if(null == instanceMaterial)
                instanceMaterial = GameObject.Instantiate<Material>(new Material(Shader.Find("UChart/HeatMap/HeatMap2D")));
            this.material = instanceMaterial;
        }

        private void Update()
        {
            this.UpdateMaterial();
        }

        public override Material GetModifiedMaterial(Material baseMaterial)
        {
            Material mat = baseMaterial;
            // TODO : ���Ը�ֵ
            return base.GetModifiedMaterial(baseMaterial);
        }

        Sprite OnePixelWhiteSprite()
        {
            Texture2D tex = new Texture2D(1,1);
            tex.SetPixel(0,0,Color.white);
            tex.Apply();
            return Sprite.Create(tex,new Rect(0,0,1,1),Vector2.zero);
        }
    }
}