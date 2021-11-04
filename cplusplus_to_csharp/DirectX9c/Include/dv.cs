// ------------------------------------------------------------------------------
// File: DV.h
// 
// Desc: DV typedefs and defines
// 
// Copyright (c) 1997-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------







// There are NTSC or PAL DV camcorders  

// DV camcorder can output sd/hd/sl  

// user can choice 12 bits or 16 bits audio from DV camcorder


public class Tag_DVAudInfo
{
    public byte[] bAudStyle = new byte[2];

    // LSB 6 bits for starting DIF sequence number
    // MSB 2 bits: 0 for mon. 1: stereo in one 5/6 DIF sequences, 2: stereo audio in both 5/6 DIF sequences
    // example: 0x00: mon, audio in first 5/6 DIF sequence
    //                 0x05: mon, audio in 2nd 5 DIF sequence
    //                 0x15: stereo, audio only in 2nd 5 DIF sequence
    //                 0x10: stereo, audio only in 1st 5/6 DIF sequence
    //                 0x20: stereo, left ch in 1st 5/6 DIF sequence, right ch in 2nd 5/6 DIF sequence
    //                 0x26: stereo, rightch in 1st 6 DIF sequence, left ch in 2nd 6 DIF sequence
    public byte[] bAudQu = new byte[2]; // qbits, only support 12, 16,

    public byte bNumAudPin; // how many pins
    public ushort[] wAvgSamplesPerPinPerFrm = new ushort[2]; // sample size for one audio pin in one frame(which has 10 or 12 DIF sequence)
    public ushort wBlkMode; // 45 for NTSC, 54 for PAL
    public ushort wDIFMode; // 5  for NTSC, 6 for PAL
    public ushort wBlkDiv; // 15  for NTSC, 18 for PAL

}

