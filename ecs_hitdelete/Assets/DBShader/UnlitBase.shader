Shader "Universal Render Pipeline/Custom/UnlitBase"
{
    Properties
    {
        _MainTex("MainTex", 2D) = "white" {}
        [HDR]_Color("Color", Color) = (1,1,1,1)

    }

    SubShader
    {
        Tags { "RenderType"="Opaque" "RenderPipeline"="UniversalRenderPipeline"}

        Pass
        {
            Tags { "LightMode"="UniversalForward" }

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct a2v
            {
                float4 vertex  : POSITION;
                float2 uv        : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv        : TEXCOORD0;
                float4 pos  : SV_POSITION;
            };

            TEXTURE2D(_MainTex);
            SAMPLER(sampler_MainTex);
            float4 _MainTex_ST;

            CBUFFER_START(UnityPerMaterial)
            half4 _Color;
            CBUFFER_END


            v2f vert(a2v v)
            {
                v2f o;
                o.pos = TransformObjectToHClip(v.vertex.xyz);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            half4 frag(v2f i) : SV_Target
            {
                return SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uv) * _Color;
            }
            ENDHLSL
        }
    }
}