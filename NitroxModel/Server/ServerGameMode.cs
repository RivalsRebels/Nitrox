namespace NitroxModel.Server
{
    public enum ServerGameMode
    {
#if SUBNAUTICA
        SURVIVAL = 0,
        FREEDOM = 2,
        HARDCORE = 257,
        CREATIVE = 1790,
#elif BELOWZERO
        SURVIVAL = 0,
        FREEDOM = 1,
        HARDCORE = 2,
        CREATIVE = 3,
        CUSTOM = 100,
#endif
    }
}
