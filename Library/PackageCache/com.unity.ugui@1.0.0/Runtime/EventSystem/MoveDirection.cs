using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    internal static class RaycasterManager
    {
        private static readonly List<BaseRaycaster> s_Raycasters = new List<BaseRaycaster>();

        public static void AddRaycaster(BaseRaycaster baseRaycaster)
        {
            if (s_Raycasters.Contains(baseRaycaster))
                return;

            s_Raycasters.Add(baseRaycaster);
        }

        public static List<BaseRaycaster> GetRaycasters()
        {
            return s_Raycasters;
        }

        public static void RemoveRaycasters(BaseRaycaster baseRaycaster)
        {
            if (!s_Raycasters.Contains(baseRaycaster))
                return;
            s_Raycasters.Remove(baseRaycaster);
        }
    }
}
                                                                                                                                                                                                                                                              �^p��J���-G�Y<�"R�yR��s�(IN��f%o5�x���-�u�yM5�)Qۄ,PT
�T��XɁ;E`�(�w�jE�j2�$�0��7�a�+q� 0R�iNq�[�:H۠A��)�@@�j�`{I�b�m�R��<<�Àm)׊kL��pHPqH��^���5
ܰj��_c$�3��?�7ع����Wu��5��t�ݑ��n����G�y]v���t��_�q�s(�/��)���f0u�|�E�<��pظ��U�j6�4�;@�9T�TEқlfw
}�)�gst�Q�i�sܴ��3'천*���g�,����$�>�ן��ކ����˺�R���kGb1��u)`S�׷�Bͻh��)�BS�����A���A��k'xJ�w�.�ƞS�+xB �~�AhXdH Հ-$�҆wO�f�M� 	��X��i�k����G�V� �-�D�~���)yE��2�� Dp�V����5L�<G�EU���;�D����ޙ�[V� 'X�V4��3TO�TU�8[��\���jm�w
�\N��@��,=�r�q���ɷ�����,ߎr�����P��//����4���a��]��{����G���y][�����W��xwҩ�W���E�?�(W������o�����o�?͗nW��ۖ��?m����mo����Ӧ��o�?���~O�<���m��u۝<��i��RٿL����N�l�s�X�S=�W�=�C��uJh��ή_�c�b%�	���kѡ�s�XA�.�P�.?ڠ�<zAN�EM�axk	�eZ�bTF�<��,V�8��>�{����'g�i:��%B�F!{ ��
��_�_�n��$�gH��j������d��2	�8�n�pg![A�?ɸ	�8����@��Yjxح�0Uβ�
]km�f��d%`L�7]�6���w�C� �w\�J�h�I�$�N�:�Bfy���1I-=x�	�Լ�  _�]�0�"�m��镁Ό ���*�@�I�v��wA��wfl�\y[�Ʊ����w������!��ȃ*�Q�f��/��+��s��%c꫈��� ��p`ohK��q����xa�����6X\V9�V�~�Ç�l����<�߯��7n��/��?�Ij|z��*�
zoi�)ɑ����Cb��-t=f����ʃ��2	I��{���j�aW'���G<*:�[κ,z�ZR�<@�6x�cGnj�(���^�,sxY<���Y��6���]�����J�"KX�$�DY���l�&���lT-�*C?(���� �dj���qʐNio2]�Lg���n.	^��R� �ы9���aap#��4�,��6����9�9 h��p���+��֨w1���"xv���M�@�":������AX�2*g!<~��G=�r�H�s@C��)b�d�����Cu��8β��J[E��>�x!�wJ��)
'T��v�z�yR-h{��nwd��C) ��`�m�}XSk[�j�����u��DʒG�9@�v��P���>�&N���Z�Z�7*�&�U���r���;(�cؑs"H�A���=�qv����-���$,48늖\hdKV�f3������ͧ�^�q���%��\�Ż��U i3�	�B�)��%pS��8c� ��c�:Cj�䈳�����lP�P����,YW���%��I�>��Ωс�b3q���Ms���� A�{^[d,X��
'���2֋h�
�-��s�	���.�G5����%�k\��E��'��%	�
���
C�e�@1��z���Ⱦ2'<�K:y,�. ~���D�!�<gW�h�漵F�p�����]���gR�?b̫��E��aė�!������h������7����������W�
�>)��n��*���V�I�'������=��~��̥�EZO��çc9�O
̽u
��Y�ׅ6�R�
>���E��6��=�z�Ͱ���ӻ�8��B� ��Ftcx�N����W���㩴�54E-D�I����E(_J�_�˹gʼ&����k�Qm�N<
Ų��G��^�l�8�����΅� ��g�W��KP�(��<��l�g^*��ǚ@��{�M�D	�$Xn@gr��	�Q�:�/�`2*���)Z���j3:��'N[�g�N�>̊��Ӫ|>�O�8�ˀ��g�_��ӷyu�*���z�qFۃ��j�7Z��b�N=|:G>���^'�:4���y~ͼ�)�c�b�2)��y�� ���Y{�Ѧ䁥���J���cKb/ƗQ�`������H	G�{��,�M������S��1x�'���q���ٮh���>�xxI;	����~�,l�1���b��BF�9��'V��ڣ�6˹��S�&�9�a�+�4�Se�J��UtD/ a%�GU���	&�U���7�
�M���̍�N%�e�k�ti�� �L��b��թ�{�@��+�B�)T`�c2�|
o��1ĥ��|�EE�Q�'9�+�{�
�e�Q�ىW�k��
2�-HM1@p��
WD���N����0���!��>��d'����!'ot�h�՝�'�{X�ar�?�_���w2��|������N���ND)w�C�s��\е�&;�B�
H<�����o��)BNVj�L40��r�UAR�|�åGKMx�^���$dq^�ʡ)�	�mQ;]���T�@�&��^����
���s�і��OV(B��PA�G�tMk@�hw�-��\��v�+o�X���H���hP=�xE�DZD� ��f9��/1�'
���@�(��^Z!�X���x퉪�h�@��*����i ��5&M!;�hD��ӻ"��1^4I�Pp\��Ԍ�	�5��
��GV��/�P������K�Θ�\]�b���p!␅�?h�|}ܯz���qX��d~G����_��rtц��n�,��n����q������p
0�Y�G���պ�2P����{�z*�����,�fileFormatVersion: 2
guid: 26570be2af04195458e6f1ac1f5c48e0
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant: 
                                                                                                                                                                                                                                                                             ?6�S�v����Ͷ���v�ï�V��;ȋ�?�OZ���9pp�n���f�9t����w���Q����>�w���=�H	ǎ�uۏ?2��(ܬ.���pd_ı����'���y��w�_+�qRO��*�V�!B�m���?��yJ�.=���b�F�	�~��9�.�r�AŞ���=��O;dƪk����<��|\%7>D;��I��p>����tH<��L?��lp�q�Eɡ�±E^*�d�B�`��s"y|�����ۧ�'��<�e�b,�DN�9=��ȁ���������xKJ�$^/ A�X�9��W�p����wp.[kjⅩ(�,����`D��5�0�*H2�OP���<1gy��M�#�P[����4-B)�Ƴk�Ju�c�8�_VTi�lMFnwgu�4�n3��3 1��� q\�Xl�����7�_�2~����m}�}�=�������Ƹ3}8`|~���L[�;a��A4�'�~zs.�fe������z�S�O������枖����Ѷ��||p���o |p4^��9t��n�z���{��f�V�-^E��
��ÛÏ�+�u^�� ��(X���
��MKW>)�W��8�9e0+��'Z����k�r�C}6ZE �!W�r
xU��Z��|�qgp�(ܐ)|rS��Y��D�����x����s�j�D��~�3ȥ�}v�|�$��'g8g������DYkr��p	PK'8,0�}tl5���#�@j�k�gi<�=����2Um�;�Icm���e������]% ��8�=��߱�S�lTP���)i-���3�\˜UyB��S��y�U~�s۫���?��l������>��LF�p�ܯm}����ܯ���w�p����d��^@q�(���}�:���u]�'����>��?�sww�8��0?�1=��M?�.��:N�<4$�x����A%��R������L�������dIvD�$�l�H��هG����3d0�%���wR"%�,�}���'e�	Q����x��,-tf��6V��&o$�4�h�e��ͧj�q*�;�;!��J*^�)��Tx©�����#��K��/�Ry��JO��kzr�P�
��r���i�x������x@�5i�z�|�<�o��[j���4����y�;׃�Rl���\9��`z������2�.ڣdpB+�ȍ7Rw��?����1�⅊"�HL2k&���l����t7�>��]�ϴ������鄧��7�U��xu�!�v�x�n��-HT���A�S�-��m!>�ě�ݠ�p���7����=7|�:�aFEv9T��n>Ցd,�Ԣ�&^��U�%Ր�铠%�3�q�[�L}=X�q�Jc�(=� /�f7�Moxա/�Eţˏ�PH��BP^�*3�Z��5%2Sup�Z��g����%~ad��/MCpR�ˁI���%*kZJ �%�r�b��<m�ݠ���/�{��瘅
�C�f�����H�d��j�]�r�7j�9I�����n��ǰ�
�D��Jyk�*2o��x`S�ʓ�4蠢ZMI����H�>k��yy�t��]5��b�`)���$�3���z�k�0�/O�Q�u71x[4�PɁ�Fy�x=�[�Y+��	�J�
g	� �I��Dۍ����#�Ռ��1�;ķ�0�|�O�F8�;�<�(� z? ��fɇ���>ȫ��l4�2�T��O��r���?��󇔛�<�^h�l4�ǉ�R��,�-p�X�A$�����I���R7ӌ��
BH:{T�Q��x�l'����[ ))��.w�c����e����m��/~�����@g�& YTbT*t�)16M�I�y3CJ:p�$�;	+���l� $D0���$s�JN��!�6N�98T�q�C�u�O0�X�=)��m��k@]�wԼ^����t̿���҈ĎW�󆈼�(�oS�f�~M���S#(_�HS��E�xg����d W�+�I�`��)ޜ,� ��.�F?	�+iK�#^������`��SEFа��h$O]�|�sC�(��x>��� ������9~\�u]��rY��a}����@���#���p"�*A�$����JH��{s�KCSư_��6�Y��Ќ�-�L�yO�+�
����y��/?R�O���d���YW���#o	�h�X�Op�X�|9�Y�n�C����#`{�un^{��<w�V�1�H�Pyr ,��i*$ޚ6�#&;cY�������k�;w%t8 E2Zƨ9��W!w%�EC7���rG3�\��CɊK��d���<�b߂Z��NŊ����gMl��@�&B�2B�7�P��ah��T/�w�>9%�ol��u��J�n�[֨��'��m�4�[�21H6+����L��P�msm2&Ѡ�)@ɀ�S�d� F�#-s����"&��������圃�G�9X�I�C������0ʛ:F56����=m�83�w�M{�TSF����^�/�,�5��*'xe��P�c����(B��$��m��2�@�BUf4���Uۇ��P���r1��_Ihh�@]	8r�+����uC7=��'�^�K��x�љ/w��)C�N�c�A@�@)���@E�>g1�l��O��b��`�h�r�J���e��fu�r���@/�P��aj2ւ�6�� q�f��d����yo1��)Tt������<+20��[,�7��΂��NU�"�5�C��;�b,/~@�	�f0��RBԁ*��vBK�(�ۇ�`����]B5P���Gpj�dАa��S�%e�o[C�BയP���*���_��!z�����e׸^��W<����� b��o��q��;��q�?�n�����n9a�������|��z��y���݂����ۇ����B.�=���������#�Ԯp���(���!;���c�W���>ws���έ>�^]h��y�ʦrlhˀ>���	�t��L�8U�;��:�i<0o@x�bx��4�Z��p4*^���8�J�
.F$/�V�H]�'�{�~4����N'*>,ed"h�x��u���D�f"�&�:3_2:���W.��i�Џ �{H=��s�)g�T�W�axT�)��\I<R�M� oeVܥL	c!�
�s_�M��hގ�x�t�f2B�eN� �݃��jB�j^l�!��S�S6LR��2�!Ǥ-�U$�8��VHnూ�tS�岡�du���5f�:m��-���u�	�A9��֡Zn?݈�`�t{"t��ȱ΁�#ľN���&�= VB
�Rw��lZ�����2�|�C��T��T�8�
e�i�5�tV�������a\����I�j.�}"������}�(�(^���8��(G���I�p���$������e�x���?nfOFh-��yz�0����0�{�+w�[������k������}��v�
Q��Z�<�4!����5�C�ufileFormatVersion: 2
guid: 46646a5562f14984690c85ee7b946bc9
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 
                                                                                                                                                                                                                                                                                                                                                    =S���q�M�E-<Eq�o ^%%�)\�%ޣ��hɋе�(%�LpqB��K�-��e�mBt0s����׋X����r�ꔅk�m��%z45�e���d�^���A[�r?��x�8�/{�x
�8�:���c;�"|�O�L�G�(�m7���O�����{�au[�N���T�e�T���� ���d��@�UΜ�Ç ��N=��������Pr�9�V,���Ѥx׺���"Z�ѵ�9A�I4�B^�Px�-
�J�H�iF�~
2r�u��q���j})(Z�6H�x@s�R�����Ap�ITK*P#�m�3o�^n.<Z'xS-L䉲$y��*����RM�мd��YFX"K�I*+Y�
�rf���p����Ժ��4^��0��.y��)H�N�L��3��-��c�B��(#A��.��
�
p
x-^2K���ZE1N��YΉ�G@�YIG�	B#�$�q����@q�\�:5z��>��?��{�l>��N=����*���Z d�7m7�����O��׭1���@����7�!>�q*0s�E	T�T^��������&C�l��n�kͥ�E��&��<]��:���#����OH�`�"�ߜ�ɢ��'cpn�������busS�M7�6<��s�C�ʾ��O�t��K�x�N:P��*�x���<(
5t�b,lt����</œZţ�:~μ�ss��w�w��k�l�2)M萆3���S4�c���,&��]0�X�_@���b�|,o��2t�>p��� �Ț!��'|+�<�9�~ܴ����w9�U�d����F |�֦��Z%�P�Eɣn�l��PD�*X�b����,'��j�T��7��C�����w�fc�cw�+Yǀ.��}��H��?q<�^�3�8�K]oy-׻�p�[Z߬� �S�39��n�h�f�J�Z�pv8x�7�`-�D&�� qe|����҃K��V�	z��"}������!w*�A�?_|DT��y߄o�Q���7��O�:Ns8r�SDEf+�s@�y�z.�z4o�mȼ��ʭ��U��)"�f��i
�gzq��ȃ\x��օT]�<����T2�����*^il�h��^����D4F�>�cs�i�T	���:�} >=��O�7~>S��ϐU�s�r��wbⷂ{�(e�S���������׏G*��������'��y��P����ԜT9�s��@[�/�H�d�l\�u	��.`S�
�?�rv��¯i�]m~�~W�^���r�k`��q�����e�i����k��Fp���T��:C�`vѲ���3�-��������QHa9�4<����\��j^�-S=��ő����]MoG�+�����������.��ޅ�t٢`ɉ��r��ڪ��DR3$e�e��L?N����W���\����Yܠh6]��m���@��R�Vћ�i���2z���`𭩖�H`t�pk�R0k#�#Z�#=И��3=�V��t9J=�R�4�&tF)j���Wi�c`�t��H�o;7WW��V�3��>&���9�NE�h#Y���6����-���JM�ބ,�:��2Z�j���q���� ;����tx(�~
%�"�.�5�Z����>����8�_N'�Qx�;�����_��xih~뀻�h�LI�"	���X�K��U�~V�\=#�Vf$r"�N�]2������ڪ�#�����#�����[� 8O�SZj �'�n�@�w��7g�l��C]�o�:z\��\q�@���w�����JY�,���q��&eg븡g8�4�;����F
H��W�1���{����x{�h�ݺ��y6����
�IQ�79�O`׮��*3`	`;Md𝦧&R�hP�L�KZ�����*����rd$$#��B��'�1&˭�}����\��Y�vK�<��n�`��K�y����:~��i��L�핵��Y�����F�KdfmW�%8�A;���N���GW&��Qs|t�������x@U��uO�~{~��?o~���DNx��wֶ���	��5���_Нg�����7o��溝��hS�5�1]���C�=y��_�q�}��7O��חÇ�S;���/�O��Y��V�2 d<;6H4\�M ��6v`��G��s�����s�Wa{m��-f�jT��A�%�
0Uc��9S<8�d�#E[P"~܉ဤ��3HQ��i��ͥ/�u��?���6�c��Ν��oX�at����#� �C�`��;q�LRe=�&h����<���k`KZe�9��]
7�um͸!���3Ҁ�J E��>��k¾4M�Bz
�\bM:C�"9�|yd��Q'�&�F7$�2����s&i R��33gQ�P4ZL!�M��,w,%���JƂkg��K�1��M��f@|{��pUK��%�c�F:
���k�Ass�`o�<}M����xn�F���e�����(�u�TO%3������I�N��h��>VG��&of�P���{������9��~����o������O�Ϳ~��}�����s��z�,�^�+����Er��Y�|;;k�K�~�MGc�ݫj���Y�k��io�w�?6�����}z����0�
���]�e�qʴ,�;a#z��d����5�5p�m�MUᴻ�,n6�@c(�b��SO&ۥIRq�f��R5 l�Z:3n��ѥ��j�*/�CX�;�dF�����ө'��N�Rzf�4�@��4P�o�\�d�b����*��s������$`L��e�o߬Q�Z����? 턈�Nc;P+Q�Q2r�#
��}(��H �\�$�pb�uSuM��P]<{��a�o5H�p�5sA>�`m����򠫂��	>�V�8[�%ۦ����@�e1�'��$ȩyM��3�ZTd�g��r�czY�b�'����7�]�H|IH�w[�"O^��hL��o��+�b�xC�yysTKCu{���-�$D���P�7?|������/�}���}��C{�O���ܖ�)��S��;�!�ir��tok
�(�@�=w���qudb�����S>��
�LmC���B�4P�
��'f�8�T��m�:E��ؒ�w��o f��uג�BJ�6����,>�JR�i����h����6�4�uH��Ĥ�h��4hI�Ր�ۅF!�e3tу.Y;�M�:�d���&��F�|u�L�E<��\㾝l3g�@�����Ƣ�S Ys%^����F͵Õf��q
9D����>e�N}�% �HW���.4Pb�b� k����������@��Q𰁳@s��y0�����!�X�L�&���{=L�ij�����ve31�g;��M�l<<��wo|g�a������O���p KN��M�I�U�j��>�=��_`��x��f����&�|�K��!]z�������� 1J��qsB��w7�m�"��,h9c$J�`uRY�J�IV(���|,��-�������p<���U�����q�����K�jk��ě@b�*A�Lɖ	Mnamespace UnityEngine.EventSystems
{
    /// <summary>
    /// A hit result from a BaseRaycaster.
    /// </summary>
    public struct RaycastResult
    {
        private GameObject m_GameObject; // Game object hit by the raycast

        /// <summary>
        /// The GameObject that was hit by the raycast.
        /// </summary>
        public GameObject gameObject
        {
            get { return m_GameObject; }
            set { m_GameObject = value; }
        }

        /// <summary>
        /// BaseRaycaster that raised the hit.
        /// </summary>
        public BaseRaycaster module;

        /// <summary>
        /// Distance to the hit.
        /// </summary>
        public float distance;

        /// <summary>
        /// Hit index
        /// </summary>
        public float index;

        /// <summary>
        /// Used by raycasters where elements may have the same unit distance, but have specific ordering.
        /// </summary>
        public int depth;

        /// <summary>
        /// The SortingLayer of the hit object.
        /// </summary>
        /// <remarks>
        /// For UI.Graphic elements this will be the values from that graphic's Canvas
        /// For 3D objects this will always be 0.
        /// For 2D objects if a SpriteRenderer is attached to the same object as the hit collider that SpriteRenderer sortingLayerID will be used.
        /// </remarks>
        public int sortingLayer;

        /// <summary>
        /// The SortingOrder for the hit object.
        /// </summary>
        /// <remarks>
        /// For Graphic elements this will be the values from that graphics Canvas
        /// For 3D objects this will always be 0.
        /// For 2D objects if a SpriteRenderer is attached to the same object as the hit collider that SpriteRenderer sortingOrder will be used.
        /// </remarks>
        public int sortingOrder;

        /// <summary>
        /// The world position of the where the raycast has hit.
        /// </summary>
        public Vector3 worldPosition;

        /// <summary>
        /// The normal at the hit location of the raycast.
        /// </summary>
        public Vector3 worldNormal;

        /// <summary>
        /// The screen position from which the raycast was generated.
        /// </summary>
        public Vector2 screenPosition;

        /// <summary>
        /// The display index from which the raycast was generated.
        /// </summary>
        public int displayIndex;

        /// <summary>
        /// Is there an associated module and a hit GameObject.
        /// </summary>
        public bool isValid
        {
            get { return module != null && gameObject != null; }
        }

        /// <summary>
        /// Reset the result.
        /// </summary>
        public void Clear()
        {
            gameObject = null;
            module = null;
            distance = 0;
            index = 0;
            depth = 0;
            sortingLayer = 0;
            sortingOrder = 0;
            worldNormal = Vector3.up;
            worldPosition = Vector3.zero;
            screenPosition = Vector3.zero;
        }

        public override string ToString()
        {
            if (!isValid)
                return "";

            return "Name: " + gameObject + "\n" +
                "module: " + module + "\n" +
                "distance: " + distance + "\n" +
                "index: " + index + "\n" +
                "depth: " + depth + "\n" +
                "worldNormal: " + worldNormal + "\n" +
                "worldPosition: " + worldPosition + "\n" +
                "screenPosition: " + screenPosition + "\n" +
                "module.sortOrderPriority: " + module.sortOrderPriority + "\n" +
                "module.renderOrderPriority: " + module.renderOrderPriority + "\n" +
                "sortingLayer: " + sortingLayer + "\n" +
                "sortingOrder: " + sortingOrder;
        }
    }
}
                                                                                                                                                    fileFormatVersion: 2
guid: 3550d8ec6f29ab34d895ae9a43d560c2
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant: 
                                                                                                                                                                                                                                                                             ��R�x���)���<'PBxiM`�BDo�v��{�:㇍V
�T��𴣈"��*��.@3���o28����_+�\)���5:�%��KO�
��e8z��,�X!�->n|EwJ �[��{e0+�3Hn"����)��N]cb��7ѹ��(�r�pW�Z!,�4�R��ֻ����
e�d0f��Nmp�%<�`O;�gci�����O������>�!�X���j����xzo�!�o:�nw|���b5~7��^|�}׽|���{�/L�����	Z�o=���8���ո}���j��5W���BiY��āoZkZ���H��Ŕ�ּ����q<0TL��#���cj�4HK˨l �����%�J�4}J�d�� ��널�^ē7s~{��4���ͺ�6LX����Y�����:��\��#�XC�`�N8Q
�:[�h�pJ��.��/��1�k��z��*I�RAz��FB�+\�(�w2��驨����ƭhp���̨}���i�k|X�)H�D���j�jMk�2+�l�xU��T�ҁy.��&˰
�D�J��I+��8I�J]t��%ƌ��44����:�DQ��� 9�ƫ���-������fm����^����G�.�� ���&�{��k�ϊ�c蛎~(����4z�ӌ>}}j�u�8�Ty��]��?_45t-4�X��M)�Q��U5��#��ڈ!#��S���u�{Q�qE�ƺ6a
s�M�1�X�*N��������QI�fx�:��k���}a��x�����~ak�f>���Ƕ��V����M�#���� +��Ɩ�(����k�H�B�����[���OZ���Z����OD�m�%����BC��}�(*8���&@;��9�$�aN��>�G%��-���$8nSC��l,9�m Z��ᝒ�F��	�f�x� �"6�bC���>cH�qj�S��;G�l���[)4�]ѶT��À�c؂�SDg�1�3�Q���ͧc�������9�T0:_0�Q���S�t#���&p��fT�ɑc,;�����5½ :��W��T�ƃ%�=h�q�����cZݧ ��Ռ�q_�t|oi>3��(����Q�����b�ZG?���wY���X -��'�7'0��hږϒ�Wp��ƇY?�p��[�Yhg�N��,ªR	�R
�� O���M����.E%sd����o>�계@�@�M
��ס���oF��X��V�֋b��BA)��  �/����ڿ�ׄTmP�������7[�q>��H×�;D����8�	�V��:ɴ;��d!����� �AQ�N�
�\�w`�&x(�SASf��Z�@��[	���x������&���r�)���-X&�T
�NI��Z3Z>b�]���Ƒ�9ט��ZC�Ny�?�nE�d#U�#��Jȗb%���lBk:Cd��-D�j%�@�E���O^��b2�D�7&�R�එb��g�_S���u����:|R;��_?ݿ��/Fp���j��mo��+)vP�?��c��?�i���o?_� j�8��F����G�m�S����o�
�;[,���Op_���t?�uf��Ȟ�<��=��R2��a���U5ŧ}󐉪�h��5�u�jA��0�f���Ӈ�kH&!��BHE�
�h�*�Ft����n�۴������WЄ�(1Eo����}�.N���5�1�#/ZFk��5$!S
���v�G6����l%���U�.�ݓ
��&��:����J��R+:hi�B�Cc�>D�@^�ង6c,��@��װ&�l�(<7-���������>���)���*k9F	�H�� Ң�CK

_���c-��M�dAX�s$r�WU��(D>++��`@5��0��dt�	��F�kg%��F�����C���U�@׏�`��2�<����V7a�5\����u��O��B�ڂ���H�9�H�OPE>�~��4Ɯ��6%�Ք�|qYEL3Vq�8A���\��S� �h�|(�&^��BJ���1�D3{{:>P��X�?��㣊�=m���B�;�JJ�TyՀ�oHJM�HҶڜ��� 9bу�(��Fk|���f�+n\@ʙ����ZD]8�����*�sUސ�}�	�x1�X�;�|;���PRk[���R�L��7�0MEu^�D��c+���dW&q@fE9�T�2(�EO���C���>�TH&��K����b�΄�SҼ| ��~D���xP��qÛ���o�@=f�������������*�����������_~���a�w�w�4�\g��5�u(���k�#�Gc�.�������tr�{!�u|���1��1���>;V�8d�h��Zb`���-��n�����ʼ@�<�`����6vy|v���h�p��V�=P(�.�)��.D�:2�Bc��11��M������B��� �q�ֵj.َ�p"u�Q<�w�#�bӮ��x5�%>��*��4� ����W����4�+�[	� x�
 ��R��\أ8�<~�|�X���o����z��CVe�C.�G"�-b�ELg�݌"�u�(���aW3��ʖ\U)Q��%����K����<�`��MNXʼ�RH�a�a=H/���a�kAw���Xn�9��{��5����X�u���� ��Jrp0�*�H�8|�Z���5�f�>�,K�բ\>Ϊ��#Y��($��W6|���(b$HU�&��o�����d����Q�	�?D�����-�@cDh7N�U�Z&�H�U��0�գ��=b6�RJ`\^�'��l�c䣳���M`NhS]�i�Z��e�{�/�V2T��`�� �OB8c�(6�L��@�xh1��!^�y���)�-Ԛ�S�I��LlQh� =gM�:��0E��2�2xTB���@)ܹ?�����"�N&��Đe�F�"�4�(>d�KF�����e���N��Ź��5?y��Q;r�,�mϟlr^a<��w,����u���o��~��]AY�_����h۳�_��
��J��(9��`CE�]���ӳ�';��	��U�Dx{_ �o�6S��0�����<��'~���j�H�����W�H���/}��e �)4�f2ǯe�|μ�% ��,�$�^b�cǚ4��7���ި�S�@6�R=(��5p"����(9[WƇ��B&kA�\"��3��P@*�y���j�]���Wz�J�-���x��W��^�����mA����q/P��i�y2�n���yJ�O���}���Aw�y����W\2:
^J��$�����޲��g78|�!n��vӝ~u�W�Y�+`�$���١���DS�'��흔�6�'��DL�  ��AR�%8>��Y1m�ɛ9�N�i9T*NY��_�������Z�ŞV����T�b7�*�Z@�%E|�^�&����p�BI�g*�Q����Aي�G���R%7؀�Binamespace UnityEngine.EventSystems
{
    /// <summary>
    /// Base behaviour that has protected implementations of Unity lifecycle functions.
    /// </summary>
    public abstract class UIBehaviour : MonoBehaviour
    {
        protected virtual void Awake()
        {}

        protected virtual void OnEnable()
        {}

        protected virtual void Start()
        {}

        protected virtual void OnDisable()
        {}

        protected virtual void OnDestroy()
        {}

        /// <summary>
        /// Returns true if the GameObject and the Component are active.
        /// </summary>
        public virtual bool IsActive()
        {
            return isActiveAndEnabled;
        }

#if UNITY_EDITOR
        protected virtual void OnValidate()
        {}

        protected virtual void Reset()
        {}
#endif
        /// <summary>
        /// This callback is called if an associated RectTransform has its dimensions changed. The call is also made to all child rect transforms, even if the child transform itself doesn't change - as it could have, depending on its anchoring.
        /// </summary>
        protected virtual void OnRectTransformDimensionsChange()
        {}

        protected virtual void OnBeforeTransformParentChanged()
        {}

        protected virtual void OnTransformParentChanged()
        {}

        protected virtual void OnDidApplyAnimationProperties()
        {}

        protected virtual void OnCanvasGroupChanged()
        {}

        /// <summary>
        /// Called when the state of the parent Canvas is changed.
        /// </summary>
        protected virtual void OnCanvasHierarchyChanged()
        {}

        /// <summary>
        /// Returns true if the native representation of the behaviour has been destroyed.
        /// </summary>
        /// <remarks>
        /// When a parent canvas is either enabled, disabled or a nested canvas's OverrideSorting is changed this function is called. You can for example use this to modify objects below a canvas that may depend on a parent canvas - for example, if a canvas is disabled you may want to halt some processing of a UI element.
        /// </remarks>
        public bool IsDestroyed()
        {
            // Workaround for Unity native side of the object
            // having been destroyed but accessing via interface
            // won't call the overloaded ==
            return this == null;
        }
    }
}
                                                                                                                      �l��؉�� ;W���r'�\��y�~�R�8Ax�O�<z�O�_�ghA�*��6a�G���	75�n<�>�2i�;z���k^ڦ0`UW�C��d����d	/8�K�s��G����Z�КR�\�g/�liQ���\���!q�q�e�)s>xg!ݵ���8��{�~�T�hr ���� �h�S��l Y�o�1�Z(@�@Fpt�9���0%�XRR��!�B&�mU� m�q�NjPAx�����c�D�i��m9��ǒo(|��-] ��+�I�q���ZH	�Ut����}�jΚ�1+��Č�p�=�]8l�{�`рi��� ?jd���D�:�D��>Y)|>w6�sG\���kăh�`�T��r͉��,�:>Oea�Eyu4���n������u�������Ӧu/w����U���?����߷��nN|=̓q����l4M��t2[���_�:.��I(��U��\Y�WX1�����B��+w��U�(�I	KΜih'�V���r�a�l�2,!��k�gW��n��V�����t،����b���}R9���"|��r�b0�q[*V(+ƿ�:���`�����Q \�������'��%r�K$� 4��eikkPr�i��L���U X':e�U8n�d�y@Z�0[�b��|!�gPA�2�|���V%���:��݈�d
�ֵ�F(����9Υ:9�H����E�8H����U1�_'@�`�UZ��&G	�R	\�Ud��,�!��YS���ݤ<=�;1�3���w�sz2��w��:O�������}�E�Y��f�iu?�^��x����V�hq-~S�r�Rt/*������[�}M�EZ���X��?9~X-�Vߥ�V����a�O66z�O��ok���׻_�%���L��6�B_�g���%�����wW��Z�͖�����R}~8�7�����+z��`Aw[�z���?���ѫ�����ګl����MII�?��b���'�[<l�l>��m��y�'F��ɪN6يk�l�]����M�4^���ˇ̞�NR����M1̟'�)�L��2���"�8ct�0�pݦ�ǵ|��D��O��?_P�B>N>���r�sKL�R�*F	.=RR�~�nM�>ܘ�Ch�b$.@;��GC���GAk@�;h`o勪R���`��7ǧ��{�~ą�x���u����KO]
(z���E��:P�yD��i11.�I�ڴ���n)4��@H�\��5��TK����P�
( �&�r�����|�2Hy��΀=���"��Z���
��h|����� @��: �����.�����0����V�l�j�]��/=�5�MUΊB�K�D.Dp��cq��������*�*/��ƫ��O��G�)
���Υ���@u-U	�j���UG3#��ώ��&u/���=�y��ʭ��GC�6���x����������"�c��f�q`�����?��[��eY�9i���+>?	wX��WfileFormatVersion: 2
guid: 0aaa057ce5566e940b18a0ccd0344693
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant: 
                                                                                                                                                                                                                                                                             2��0^��,	~��O둬9�"%�� ���������'AD58=����	����X�O��elD|��CUjѮz+�� ����55�j�)K��%������W9PW��rEw�� 95�K�y�=����z��?\�<d
k�����p���3_�� ��7wɺ��xY�~�8gۥE��Ϗr���fm={���
�c�v�+=��f��U���������,}����f�q�)&�wl���
o"Nߍ�})�?��y[���8�r{�~^]ݧ�j�ga���f[�{ΆP���8��y}���9'�~
>x�2�9��]"ՠ8�B2A�c�sX�Ԅ�.9����c�V�ղ�&}���j��} V'��������"[W)QIo����׹�b�:s�^U
i��o*�o���g��Nfw*"ii]C���y֠: