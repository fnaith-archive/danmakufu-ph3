namespace Directx.Util
{
    public enum BlendType : int
    {
        MODE_BLEND_NONE = 0, // �Ȃ�
        MODE_BLEND_ALPHA = 1, // ���Ŕ���������
        MODE_BLEND_ADD_RGB = 2, // RGB�ŉ��Z����
        MODE_BLEND_ADD_ARGB = 3, // ���ŉ��Z����
        MODE_BLEND_MULTIPLY = 4, // ��Z����
        MODE_BLEND_SUBTRACT = 5, // ���Z����
        MODE_BLEND_SHADOW = 6, // �e�`��p
        MODE_BLEND_INV_DESTRGB = 7, // �`���F���]����
    }
}
