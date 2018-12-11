Shader "Custom/test1" {
    Properties{
        _BaseColor("Base Color", Color) = (0,0,0,1)
        _MainTex("Base (RGBA)", 2D) = "white" {}
    }
    SubShader{
        Tags
        {
            "Queue" = "Transparent-1"
            "RenderType" = "Transparent"
        }
        Cull Off
        ZWrite On

        CGPROGRAM
        #pragma surface surf SimpleVertex alpha

        half4 LightingSimpleVertex(SurfaceOutput s, half3 lightDir, half atten)
        {
            half4 c;
            c.rgb = 0.0;
            c.a = s.Alpha;
            return c;
        }

        sampler2D _MainTex;
        half4 _BaseColor;

        struct Input {
            float2 uv_MainTex;
            float4 color : COLOR;
        };

        void surf(Input IN, inout SurfaceOutput o) {
            half4 c = tex2D(_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb +_BaseColor.rgb;
            o.Alpha = c.a *IN.color.a;
        }
        ENDCG
    }
}