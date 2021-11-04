/*==========================================================================;
 *
 *  Copyright (C) 1996-1997 Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       dplobby.h
 *  Content:    DirectPlayLobby include file
 ***************************************************************************/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DWORD_PTR DWORD
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define VOL volatile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DPHRESULT( code ) MAKE_HRESULT( 1, _FACDP, code )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectPlayEnumerate DirectPlayEnumerateW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectPlayEnumerate DirectPlayEnumerateA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectPlay2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_AddPlayerToGroup(p,a,b) (p)->lpVtbl->AddPlayerToGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Close(p) (p)->lpVtbl->Close(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_CreateGroup(p,a,b,c,d,e) (p)->lpVtbl->CreateGroup(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_CreatePlayer(p,a,b,c,d,e,f) (p)->lpVtbl->CreatePlayer(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_DeletePlayerFromGroup(p,a,b) (p)->lpVtbl->DeletePlayerFromGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_DestroyGroup(p,a) (p)->lpVtbl->DestroyGroup(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_DestroyPlayer(p,a) (p)->lpVtbl->DestroyPlayer(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_EnumGroupPlayers(p,a,b,c,d,e) (p)->lpVtbl->EnumGroupPlayers(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_EnumGroups(p,a,b,c,d) (p)->lpVtbl->EnumGroups(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_EnumPlayers(p,a,b,c,d) (p)->lpVtbl->EnumPlayers(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_EnumSessions(p,a,b,c,d,e) (p)->lpVtbl->EnumSessions(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetCaps(p,a,b) (p)->lpVtbl->GetCaps(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetMessageCount(p,a,b) (p)->lpVtbl->GetMessageCount(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetGroupData(p,a,b,c,d) (p)->lpVtbl->GetGroupData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetGroupName(p,a,b,c) (p)->lpVtbl->GetGroupName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetPlayerAddress(p,a,b,c) (p)->lpVtbl->GetPlayerAddress(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetPlayerCaps(p,a,b,c) (p)->lpVtbl->GetPlayerCaps(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetPlayerData(p,a,b,c,d) (p)->lpVtbl->GetPlayerData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetPlayerName(p,a,b,c) (p)->lpVtbl->GetPlayerName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetSessionDesc(p,a,b) (p)->lpVtbl->GetSessionDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Initialize(p,a) (p)->lpVtbl->Initialize(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Open(p,a,b) (p)->lpVtbl->Open(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Receive(p,a,b,c,d,e) (p)->lpVtbl->Receive(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Send(p,a,b,c,d,e) (p)->lpVtbl->Send(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetGroupData(p,a,b,c,d) (p)->lpVtbl->SetGroupData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetGroupName(p,a,b,c) (p)->lpVtbl->SetGroupName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetPlayerData(p,a,b,c,d) (p)->lpVtbl->SetPlayerData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetPlayerName(p,a,b,c) (p)->lpVtbl->SetPlayerName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetSessionDesc(p,a,b) (p)->lpVtbl->SetSessionDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_AddPlayerToGroup(p,a,b) (p)->AddPlayerToGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Close(p) (p)->Close()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_CreateGroup(p,a,b,c,d,e) (p)->CreateGroup(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_CreatePlayer(p,a,b,c,d,e,f) (p)->CreatePlayer(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_DeletePlayerFromGroup(p,a,b) (p)->DeletePlayerFromGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_DestroyGroup(p,a) (p)->DestroyGroup(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_DestroyPlayer(p,a) (p)->DestroyPlayer(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_EnumGroupPlayers(p,a,b,c,d,e) (p)->EnumGroupPlayers(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_EnumGroups(p,a,b,c,d) (p)->EnumGroups(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_EnumPlayers(p,a,b,c,d) (p)->EnumPlayers(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_EnumSessions(p,a,b,c,d,e) (p)->EnumSessions(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetCaps(p,a,b) (p)->GetCaps(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetMessageCount(p,a,b) (p)->GetMessageCount(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetGroupData(p,a,b,c,d) (p)->GetGroupData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetGroupName(p,a,b,c) (p)->GetGroupName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetPlayerAddress(p,a,b,c) (p)->GetPlayerAddress(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetPlayerCaps(p,a,b,c) (p)->GetPlayerCaps(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetPlayerData(p,a,b,c,d) (p)->GetPlayerData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetPlayerName(p,a,b,c) (p)->GetPlayerName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_GetSessionDesc(p,a,b) (p)->GetSessionDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Initialize(p,a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Open(p,a,b) (p)->Open(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Receive(p,a,b,c,d,e) (p)->Receive(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_Send(p,a,b,c,d,e) (p)->Send(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetGroupData(p,a,b,c,d) (p)->SetGroupData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetGroupName(p,a,b,c) (p)->SetGroupName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetPlayerData(p,a,b,c,d) (p)->SetPlayerData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetPlayerName(p,a,b,c) (p)->SetPlayerName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay2_SetSessionDesc(p,a,b) (p)->SetSessionDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectPlay3
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_AddPlayerToGroup(p,a,b) (p)->lpVtbl->AddPlayerToGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Close(p) (p)->lpVtbl->Close(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_CreateGroup(p,a,b,c,d,e) (p)->lpVtbl->CreateGroup(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_CreatePlayer(p,a,b,c,d,e,f) (p)->lpVtbl->CreatePlayer(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_DeletePlayerFromGroup(p,a,b) (p)->lpVtbl->DeletePlayerFromGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_DestroyGroup(p,a) (p)->lpVtbl->DestroyGroup(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_DestroyPlayer(p,a) (p)->lpVtbl->DestroyPlayer(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumGroupPlayers(p,a,b,c,d,e) (p)->lpVtbl->EnumGroupPlayers(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumGroups(p,a,b,c,d) (p)->lpVtbl->EnumGroups(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumPlayers(p,a,b,c,d) (p)->lpVtbl->EnumPlayers(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumSessions(p,a,b,c,d,e) (p)->lpVtbl->EnumSessions(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetCaps(p,a,b) (p)->lpVtbl->GetCaps(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetMessageCount(p,a,b) (p)->lpVtbl->GetMessageCount(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupData(p,a,b,c,d) (p)->lpVtbl->GetGroupData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupName(p,a,b,c) (p)->lpVtbl->GetGroupName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerAddress(p,a,b,c) (p)->lpVtbl->GetPlayerAddress(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerCaps(p,a,b,c) (p)->lpVtbl->GetPlayerCaps(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerData(p,a,b,c,d) (p)->lpVtbl->GetPlayerData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerName(p,a,b,c) (p)->lpVtbl->GetPlayerName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetSessionDesc(p,a,b) (p)->lpVtbl->GetSessionDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Initialize(p,a) (p)->lpVtbl->Initialize(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Open(p,a,b) (p)->lpVtbl->Open(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Receive(p,a,b,c,d,e) (p)->lpVtbl->Receive(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Send(p,a,b,c,d,e) (p)->lpVtbl->Send(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetGroupData(p,a,b,c,d) (p)->lpVtbl->SetGroupData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetGroupName(p,a,b,c) (p)->lpVtbl->SetGroupName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetPlayerData(p,a,b,c,d) (p)->lpVtbl->SetPlayerData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetPlayerName(p,a,b,c) (p)->lpVtbl->SetPlayerName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetSessionDesc(p,a,b) (p)->lpVtbl->SetSessionDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_AddGroupToGroup(p,a,b) (p)->lpVtbl->AddGroupToGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_CreateGroupInGroup(p,a,b,c,d,e,f) (p)->lpVtbl->CreateGroupInGroup(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_DeleteGroupFromGroup(p,a,b) (p)->lpVtbl->DeleteGroupFromGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumConnections(p,a,b,c,d) (p)->lpVtbl->EnumConnections(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumGroupsInGroup(p,a,b,c,d,e) (p)->lpVtbl->EnumGroupsInGroup(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupConnectionSettings(p,a,b,c,d) (p)->lpVtbl->GetGroupConnectionSettings(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_InitializeConnection(p,a,b) (p)->lpVtbl->InitializeConnection(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SecureOpen(p,a,b,c,d) (p)->lpVtbl->SecureOpen(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SendChatMessage(p,a,b,c,d) (p)->lpVtbl->SendChatMessage(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetGroupConnectionSettings(p,a,b,c) (p)->lpVtbl->SetGroupConnectionSettings(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_StartSession(p,a,b) (p)->lpVtbl->StartSession(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupFlags(p,a,b) (p)->lpVtbl->GetGroupFlags(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupParent(p,a,b) (p)->lpVtbl->GetGroupParent(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerAccount(p,a,b,c,d) (p)->lpVtbl->GetPlayerAccount(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerFlags(p,a,b) (p)->lpVtbl->GetPlayerFlags(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_AddPlayerToGroup(p,a,b) (p)->AddPlayerToGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Close(p) (p)->Close()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_CreateGroup(p,a,b,c,d,e) (p)->CreateGroup(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_CreatePlayer(p,a,b,c,d,e,f) (p)->CreatePlayer(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_DeletePlayerFromGroup(p,a,b) (p)->DeletePlayerFromGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_DestroyGroup(p,a) (p)->DestroyGroup(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_DestroyPlayer(p,a) (p)->DestroyPlayer(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumGroupPlayers(p,a,b,c,d,e) (p)->EnumGroupPlayers(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumGroups(p,a,b,c,d) (p)->EnumGroups(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumPlayers(p,a,b,c,d) (p)->EnumPlayers(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumSessions(p,a,b,c,d,e) (p)->EnumSessions(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetCaps(p,a,b) (p)->GetCaps(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetMessageCount(p,a,b) (p)->GetMessageCount(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupData(p,a,b,c,d) (p)->GetGroupData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupName(p,a,b,c) (p)->GetGroupName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerAddress(p,a,b,c) (p)->GetPlayerAddress(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerCaps(p,a,b,c) (p)->GetPlayerCaps(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerData(p,a,b,c,d) (p)->GetPlayerData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerName(p,a,b,c) (p)->GetPlayerName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetSessionDesc(p,a,b) (p)->GetSessionDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Initialize(p,a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Open(p,a,b) (p)->Open(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Receive(p,a,b,c,d,e) (p)->Receive(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_Send(p,a,b,c,d,e) (p)->Send(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetGroupData(p,a,b,c,d) (p)->SetGroupData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetGroupName(p,a,b,c) (p)->SetGroupName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetPlayerData(p,a,b,c,d) (p)->SetPlayerData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetPlayerName(p,a,b,c) (p)->SetPlayerName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetSessionDesc(p,a,b) (p)->SetSessionDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_AddGroupToGroup(p,a,b) (p)->AddGroupToGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_CreateGroupInGroup(p,a,b,c,d,e,f) (p)->CreateGroupInGroup(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_DeleteGroupFromGroup(p,a,b) (p)->DeleteGroupFromGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumConnections(p,a,b,c,d) (p)->EnumConnections(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_EnumGroupsInGroup(p,a,b,c,d,e) (p)->EnumGroupsInGroup(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupConnectionSettings(p,a,b,c,d) (p)->GetGroupConnectionSettings(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_InitializeConnection(p,a,b) (p)->InitializeConnection(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SecureOpen(p,a,b,c,d) (p)->SecureOpen(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SendChatMessage(p,a,b,c,d) (p)->SendChatMessage(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_SetGroupConnectionSettings(p,a,b,c) (p)->SetGroupConnectionSettings(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_StartSession(p,a,b) (p)->StartSession(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupFlags(p,a,b) (p)->GetGroupFlags(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetGroupParent(p,a,b) (p)->GetGroupParent(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerAccount(p,a,b,c,d) (p)->GetPlayerAccount(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay3_GetPlayerFlags(p,a,b) (p)->GetPlayerFlags(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectPlay4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_AddPlayerToGroup(p,a,b) (p)->lpVtbl->AddPlayerToGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CancelMessage(p,a,b) (p)->lpVtbl->CancelMessage(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CancelPriority(p,a,b,c) (p)->lpVtbl->CancelPriority(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Close(p) (p)->lpVtbl->Close(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CreateGroup(p,a,b,c,d,e) (p)->lpVtbl->CreateGroup(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CreatePlayer(p,a,b,c,d,e,f) (p)->lpVtbl->CreatePlayer(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_DeletePlayerFromGroup(p,a,b) (p)->lpVtbl->DeletePlayerFromGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_DestroyGroup(p,a) (p)->lpVtbl->DestroyGroup(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_DestroyPlayer(p,a) (p)->lpVtbl->DestroyPlayer(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumGroupPlayers(p,a,b,c,d,e) (p)->lpVtbl->EnumGroupPlayers(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumGroups(p,a,b,c,d) (p)->lpVtbl->EnumGroups(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumPlayers(p,a,b,c,d) (p)->lpVtbl->EnumPlayers(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumSessions(p,a,b,c,d,e) (p)->lpVtbl->EnumSessions(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetCaps(p,a,b) (p)->lpVtbl->GetCaps(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetMessageCount(p,a,b) (p)->lpVtbl->GetMessageCount(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetMessageQueue(p,a,b,c,d,e) (p)->lpVtbl->GetMessageQueue(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupData(p,a,b,c,d) (p)->lpVtbl->GetGroupData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupName(p,a,b,c) (p)->lpVtbl->GetGroupName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerAddress(p,a,b,c) (p)->lpVtbl->GetPlayerAddress(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerCaps(p,a,b,c) (p)->lpVtbl->GetPlayerCaps(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerData(p,a,b,c,d) (p)->lpVtbl->GetPlayerData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerName(p,a,b,c) (p)->lpVtbl->GetPlayerName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetSessionDesc(p,a,b) (p)->lpVtbl->GetSessionDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Initialize(p,a) (p)->lpVtbl->Initialize(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Open(p,a,b) (p)->lpVtbl->Open(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Receive(p,a,b,c,d,e) (p)->lpVtbl->Receive(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Send(p,a,b,c,d,e) (p)->lpVtbl->Send(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SendEx(p,a,b,c,d,e,f,g,h,i) (p)->lpVtbl->SendEx(p,a,b,c,d,e,f,g,h,i)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetGroupData(p,a,b,c,d) (p)->lpVtbl->SetGroupData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetGroupName(p,a,b,c) (p)->lpVtbl->SetGroupName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetPlayerData(p,a,b,c,d) (p)->lpVtbl->SetPlayerData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetPlayerName(p,a,b,c) (p)->lpVtbl->SetPlayerName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetSessionDesc(p,a,b) (p)->lpVtbl->SetSessionDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_AddGroupToGroup(p,a,b) (p)->lpVtbl->AddGroupToGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CreateGroupInGroup(p,a,b,c,d,e,f) (p)->lpVtbl->CreateGroupInGroup(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_DeleteGroupFromGroup(p,a,b) (p)->lpVtbl->DeleteGroupFromGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumConnections(p,a,b,c,d) (p)->lpVtbl->EnumConnections(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumGroupsInGroup(p,a,b,c,d,e) (p)->lpVtbl->EnumGroupsInGroup(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupConnectionSettings(p,a,b,c,d) (p)->lpVtbl->GetGroupConnectionSettings(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_InitializeConnection(p,a,b) (p)->lpVtbl->InitializeConnection(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SecureOpen(p,a,b,c,d) (p)->lpVtbl->SecureOpen(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SendChatMessage(p,a,b,c,d) (p)->lpVtbl->SendChatMessage(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetGroupConnectionSettings(p,a,b,c) (p)->lpVtbl->SetGroupConnectionSettings(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_StartSession(p,a,b) (p)->lpVtbl->StartSession(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupFlags(p,a,b) (p)->lpVtbl->GetGroupFlags(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupParent(p,a,b) (p)->lpVtbl->GetGroupParent(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerAccount(p,a,b,c,d) (p)->lpVtbl->GetPlayerAccount(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerFlags(p,a,b) (p)->lpVtbl->GetPlayerFlags(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupOwner(p,a,b) (p)->lpVtbl->GetGroupOwner(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetGroupOwner(p,a,b) (p)->lpVtbl->SetGroupOwner(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_AddPlayerToGroup(p,a,b) (p)->AddPlayerToGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CancelMessage(p,a,b) (p)->CancelMessage(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CancelPriority(p,a,b,c) (p)->CancelPriority(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Close(p) (p)->Close()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CreateGroup(p,a,b,c,d,e) (p)->CreateGroup(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CreatePlayer(p,a,b,c,d,e,f) (p)->CreatePlayer(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_DeletePlayerFromGroup(p,a,b) (p)->DeletePlayerFromGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_DestroyGroup(p,a) (p)->DestroyGroup(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_DestroyPlayer(p,a) (p)->DestroyPlayer(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumGroupPlayers(p,a,b,c,d,e) (p)->EnumGroupPlayers(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumGroups(p,a,b,c,d) (p)->EnumGroups(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumPlayers(p,a,b,c,d) (p)->EnumPlayers(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumSessions(p,a,b,c,d,e) (p)->EnumSessions(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetCaps(p,a,b) (p)->GetCaps(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetMessageCount(p,a,b) (p)->GetMessageCount(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetMessageQueue(p,a,b,c,d,e) (p)->GetMessageQueue(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupData(p,a,b,c,d) (p)->GetGroupData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupName(p,a,b,c) (p)->GetGroupName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerAddress(p,a,b,c) (p)->GetPlayerAddress(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerCaps(p,a,b,c) (p)->GetPlayerCaps(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerData(p,a,b,c,d) (p)->GetPlayerData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerName(p,a,b,c) (p)->GetPlayerName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetSessionDesc(p,a,b) (p)->GetSessionDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Initialize(p,a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Open(p,a,b) (p)->Open(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Receive(p,a,b,c,d,e) (p)->Receive(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_Send(p,a,b,c,d,e) (p)->Send(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SendEx(p,a,b,c,d,e,f,g,h,i) (p)->SendEx(a,b,c,d,e,f,g,h,i)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetGroupData(p,a,b,c,d) (p)->SetGroupData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetGroupName(p,a,b,c) (p)->SetGroupName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetPlayerData(p,a,b,c,d) (p)->SetPlayerData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetPlayerName(p,a,b,c) (p)->SetPlayerName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetSessionDesc(p,a,b) (p)->SetSessionDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_AddGroupToGroup(p,a,b) (p)->AddGroupToGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_CreateGroupInGroup(p,a,b,c,d,e,f) (p)->CreateGroupInGroup(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_DeleteGroupFromGroup(p,a,b) (p)->DeleteGroupFromGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumConnections(p,a,b,c,d) (p)->EnumConnections(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_EnumGroupsInGroup(p,a,b,c,d,e) (p)->EnumGroupsInGroup(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupConnectionSettings(p,a,b,c,d) (p)->GetGroupConnectionSettings(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_InitializeConnection(p,a,b) (p)->InitializeConnection(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SecureOpen(p,a,b,c,d) (p)->SecureOpen(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SendChatMessage(p,a,b,c,d) (p)->SendChatMessage(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetGroupConnectionSettings(p,a,b,c) (p)->SetGroupConnectionSettings(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_StartSession(p,a,b) (p)->StartSession(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupFlags(p,a,b) (p)->GetGroupFlags(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupParent(p,a,b) (p)->GetGroupParent(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerAccount(p,a,b,c,d) (p)->GetPlayerAccount(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetPlayerFlags(p,a,b) (p)->GetPlayerFlags(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_GetGroupOwner(p,a,b) (p)->GetGroupOwner(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlayX_SetGroupOwner(p,a,b) (p)->SetGroupOwner(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPENUMGROUPS_ALL DPENUMPLAYERS_ALL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPENUMGROUPS_LOCAL DPENUMPLAYERS_LOCAL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPENUMGROUPS_REMOTE DPENUMPLAYERS_REMOTE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPENUMGROUPS_SESSION DPENUMPLAYERS_SESSION
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPPLAYER_SERVERPLAYER DPENUMPLAYERS_SERVERPLAYER
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPPLAYER_SPECTATOR DPENUMPLAYERS_SPECTATOR
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPPLAYER_LOCAL DPENUMPLAYERS_LOCAL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPPLAYER_OWNER DPENUMPLAYERS_OWNER
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPGROUP_STAGINGAREA DPENUMGROUPS_STAGINGAREA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPGROUP_LOCAL DPENUMGROUPS_LOCAL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPGROUP_HIDDEN DPENUMGROUPS_HIDDEN
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPOPEN_RETURNSTATUS DPENUMSESSIONS_RETURNSTATUS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPLCONNECTION_CREATESESSION DPOPEN_CREATE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPLCONNECTION_JOINSESSION DPOPEN_JOIN
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPSEND_MAX_PRIORITY DPSEND_MAX_PRI
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPCONNECT_RETURNSTATUS (DPENUMSESSIONS_RETURNSTATUS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DP_OK S_OK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ALREADYINITIALIZED MAKE_DPHRESULT( 5 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ACCESSDENIED MAKE_DPHRESULT( 10 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ACTIVEPLAYERS MAKE_DPHRESULT( 20 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_BUFFERTOOSMALL MAKE_DPHRESULT( 30 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTADDPLAYER MAKE_DPHRESULT( 40 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTCREATEGROUP MAKE_DPHRESULT( 50 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTCREATEPLAYER MAKE_DPHRESULT( 60 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTCREATESESSION MAKE_DPHRESULT( 70 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CAPSNOTAVAILABLEYET MAKE_DPHRESULT( 80 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_EXCEPTION MAKE_DPHRESULT( 90 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_GENERIC E_FAIL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDFLAGS MAKE_DPHRESULT( 120 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDOBJECT MAKE_DPHRESULT( 130 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPARAM E_INVALIDARG
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPARAMS DPERR_INVALIDPARAM
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPLAYER MAKE_DPHRESULT( 150 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDGROUP MAKE_DPHRESULT( 155 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOCAPS MAKE_DPHRESULT( 160 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOCONNECTION MAKE_DPHRESULT( 170 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOMEMORY E_OUTOFMEMORY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_OUTOFMEMORY DPERR_NOMEMORY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOMESSAGES MAKE_DPHRESULT( 190 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NONAMESERVERFOUND MAKE_DPHRESULT( 200 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOPLAYERS MAKE_DPHRESULT( 210 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOSESSIONS MAKE_DPHRESULT( 220 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_PENDING E_PENDING
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_SENDTOOBIG MAKE_DPHRESULT( 230 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_TIMEOUT MAKE_DPHRESULT( 240 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNAVAILABLE MAKE_DPHRESULT( 250 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNSUPPORTED E_NOTIMPL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_BUSY MAKE_DPHRESULT( 270 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_USERCANCEL MAKE_DPHRESULT( 280 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOINTERFACE E_NOINTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANNOTCREATESERVER MAKE_DPHRESULT( 290 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_PLAYERLOST MAKE_DPHRESULT( 300 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_SESSIONLOST MAKE_DPHRESULT( 310 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNINITIALIZED MAKE_DPHRESULT( 320 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NONEWPLAYERS MAKE_DPHRESULT( 330 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPASSWORD MAKE_DPHRESULT( 340 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CONNECTING MAKE_DPHRESULT( 350 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CONNECTIONLOST MAKE_DPHRESULT( 360 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNKNOWNMESSAGE MAKE_DPHRESULT( 370 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANCELFAILED MAKE_DPHRESULT( 380 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPRIORITY MAKE_DPHRESULT( 390 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOTHANDLED MAKE_DPHRESULT( 400 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANCELLED MAKE_DPHRESULT( 410 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ABORTED MAKE_DPHRESULT( 420 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_BUFFERTOOLARGE MAKE_DPHRESULT( 1000 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTCREATEPROCESS MAKE_DPHRESULT( 1010 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_APPNOTSTARTED MAKE_DPHRESULT( 1020 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDINTERFACE MAKE_DPHRESULT( 1030 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOSERVICEPROVIDER MAKE_DPHRESULT( 1040 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNKNOWNAPPLICATION MAKE_DPHRESULT( 1050 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOTLOBBIED MAKE_DPHRESULT( 1070 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_SERVICEPROVIDERLOADED MAKE_DPHRESULT( 1080 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ALREADYREGISTERED MAKE_DPHRESULT( 1090 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOTREGISTERED MAKE_DPHRESULT( 1100 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_AUTHENTICATIONFAILED MAKE_DPHRESULT( 2000 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTLOADSSPI MAKE_DPHRESULT( 2010 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ENCRYPTIONFAILED MAKE_DPHRESULT( 2020 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_SIGNFAILED MAKE_DPHRESULT( 2030 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTLOADSECURITYPACKAGE MAKE_DPHRESULT( 2040 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ENCRYPTIONNOTSUPPORTED MAKE_DPHRESULT( 2050 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTLOADCAPI MAKE_DPHRESULT( 2060 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOTLOGGEDIN MAKE_DPHRESULT( 2070 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_LOGONDENIED MAKE_DPHRESULT( 2080 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPOPEN_OPENSESSION DPOPEN_JOIN
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPOPEN_CREATESESSION DPOPEN_CREATE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPSEND_GUARANTEE DPSEND_GUARANTEED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPCAPS_NAMESERVER DPCAPS_ISHOST
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectPlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_AddPlayerToGroup(p,a,b) (p)->lpVtbl->AddPlayerToGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Close(p) (p)->lpVtbl->Close(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_CreateGroup(p,a,b,c) (p)->lpVtbl->CreateGroup(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_CreatePlayer(p,a,b,c,d) (p)->lpVtbl->CreatePlayer(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_DeletePlayerFromGroup(p,a,b) (p)->lpVtbl->DeletePlayerFromGroup(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_DestroyGroup(p,a) (p)->lpVtbl->DestroyGroup(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_DestroyPlayer(p,a) (p)->lpVtbl->DestroyPlayer(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnableNewPlayers(p,a) (p)->lpVtbl->EnableNewPlayers(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnumGroupPlayers(p,a,b,c,d) (p)->lpVtbl->EnumGroupPlayers(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnumGroups(p,a,b,c,d) (p)->lpVtbl->EnumGroups(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnumPlayers(p,a,b,c,d) (p)->lpVtbl->EnumPlayers(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnumSessions(p,a,b,c,d,e) (p)->lpVtbl->EnumSessions(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_GetCaps(p,a) (p)->lpVtbl->GetCaps(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_GetMessageCount(p,a,b) (p)->lpVtbl->GetMessageCount(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_GetPlayerCaps(p,a,b) (p)->lpVtbl->GetPlayerCaps(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_GetPlayerName(p,a,b,c,d,e) (p)->lpVtbl->GetPlayerName(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Initialize(p,a) (p)->lpVtbl->Initialize(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Open(p,a) (p)->lpVtbl->Open(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Receive(p,a,b,c,d,e) (p)->lpVtbl->Receive(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_SaveSession(p,a) (p)->lpVtbl->SaveSession(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Send(p,a,b,c,d,e) (p)->lpVtbl->Send(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_SetPlayerName(p,a,b,c) (p)->lpVtbl->SetPlayerName(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_AddPlayerToGroup(p,a,b) (p)->AddPlayerToGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Close(p) (p)->Close()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_CreateGroup(p,a,b,c) (p)->CreateGroup(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_CreatePlayer(p,a,b,c,d) (p)->CreatePlayer(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_DeletePlayerFromGroup(p,a,b) (p)->DeletePlayerFromGroup(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_DestroyGroup(p,a) (p)->DestroyGroup(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_DestroyPlayer(p,a) (p)->DestroyPlayer(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnableNewPlayers(p,a) (p)->EnableNewPlayers(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnumGroupPlayers(p,a,b,c,d) (p)->EnumGroupPlayers(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnumGroups(p,a,b,c,d) (p)->EnumGroups(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnumPlayers(p,a,b,c,d) (p)->EnumPlayers(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_EnumSessions(p,a,b,c,d,e) (p)->EnumSessions(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_GetCaps(p,a) (p)->GetCaps(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_GetMessageCount(p,a,b) (p)->GetMessageCount(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_GetPlayerCaps(p,a,b) (p)->GetPlayerCaps(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_GetPlayerName(p,a,b,c,d,e) (p)->GetPlayerName(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Initialize(p,a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Open(p,a) (p)->Open(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Receive(p,a,b,c,d,e) (p)->Receive(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_SaveSession(p,a) (p)->SaveSession(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Send(p,a,b,c,d,e) (p)->Send(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_SetPlayerName(p,a,b,c) (p)->SetPlayerName(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectPlay_Release(p) (p)->Release()

/* avoid warnings at Level 4 */
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4201)

#if __cplusplus
#endif // __cplusplus

/*
 * GUIDS used by DirectPlay objects
 */

/* {AF465C71-9588-11cf-A020-00AA006157AC} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayLobby, 0xaf465c71, 0x9588, 0x11cf, 0xa0, 0x20, 0x0, 0xaa, 0x0, 0x61, 0x57, 0xac);
/* {26C66A70-B367-11cf-A024-00AA006157AC} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayLobbyA, 0x26c66a70, 0xb367, 0x11cf, 0xa0, 0x24, 0x0, 0xaa, 0x0, 0x61, 0x57, 0xac);
/* {0194C220-A303-11d0-9C4F-00A0C905425E} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayLobby2, 0x194c220, 0xa303, 0x11d0, 0x9c, 0x4f, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);
/* {1BB4AF80-A303-11d0-9C4F-00A0C905425E} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayLobby2A, 0x1bb4af80, 0xa303, 0x11d0, 0x9c, 0x4f, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);
/* {2DB72490-652C-11d1-A7A8-0000F803ABFC} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayLobby3, 0x2db72490, 0x652c, 0x11d1, 0xa7, 0xa8, 0x0, 0x0, 0xf8, 0x3, 0xab, 0xfc);
/* {2DB72491-652C-11d1-A7A8-0000F803ABFC} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayLobby3A, 0x2db72491, 0x652c, 0x11d1, 0xa7, 0xa8, 0x0, 0x0, 0xf8, 0x3, 0xab, 0xfc);
/* {2FE8F810-B2A5-11d0-A787-0000F803ABFC} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlayLobby, 0x2fe8f810, 0xb2a5, 0x11d0, 0xa7, 0x87, 0x0, 0x0, 0xf8, 0x3, 0xab, 0xfc);


/****************************************************************************
 *
 * IDirectPlayLobby Structures
 *
 * Various structures used to invoke DirectPlayLobby.
 *
 ****************************************************************************/





/*
 * DPLAPPINFO
 * Used to hold information about a registered DirectPlay
 * application
 */
public class DPLAPPINFO
{
    public uint dwSize; // Size of this structure
    public GUID guidApplication = new GUID(); // GUID of the Application
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszAppNameA; // Pointer to the Application Name
//        char* lpszAppName;
//    };

}

/*
 * LPCDPLAPPINFO
 * A constant pointer to DPLAPPINFO
 */

/*
 * DPCOMPOUNDADDRESSELEMENT
 *
 * An array of these is passed to CreateCompoundAddresses()
 */
public class DPCOMPOUNDADDRESSELEMENT
{
    public GUID guidDataType = new GUID();
    public uint dwDataSize;
    public object lpData;
}

/*
 * LPCDPCOMPOUNDADDRESSELEMENT
 * A constant pointer to DPCOMPOUNDADDRESSELEMENT
 */

/*
 * LPDPAPPLICATIONDESC
 * Used to register a DirectPlay application
 */
public class DPAPPLICATIONDESC
{
    public uint dwSize;
    public uint dwFlags;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszApplicationNameA;
//        char* lpszApplicationName;
//    };
    public GUID guidApplication = new GUID();
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszFilenameA;
//        char* lpszFilename;
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszCommandLineA;
//        char* lpszCommandLine;
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszPathA;
//        char* lpszPath;
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszCurrentDirectoryA;
//        char* lpszCurrentDirectory;
//    };
    public string lpszDescriptionA;
    public string lpszDescriptionW;
}

/*
 * LPDPAPPLICATIONDESC2
 * Used to register a DirectPlay application
 */
public class DPAPPLICATIONDESC2
{
    public uint dwSize;
    public uint dwFlags;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszApplicationNameA;
//        char* lpszApplicationName;
//    };
    public GUID guidApplication = new GUID();
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszFilenameA;
//        char* lpszFilename;
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszCommandLineA;
//        char* lpszCommandLine;
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszPathA;
//        char* lpszPath;
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszCurrentDirectoryA;
//        char* lpszCurrentDirectory;
//    };
    public string lpszDescriptionA;
    public string lpszDescriptionW;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        char* lpszAppLauncherNameA;
//        char* lpszAppLauncherName;
//    };
}


/****************************************************************************
 *
 * Enumeration Method Callback Prototypes
 *
 ****************************************************************************/

/*
 * Callback for EnumAddress()
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL *LPDPENUMADDRESSCALLBACK)(REFGUID guidDataType, uint dwDataSize, LPCVOID lpData, object* lpContext);
public delegate bool LPDPENUMADDRESSCALLBACK(REFGUID guidDataType, uint dwDataSize, LPCVOID lpData, object lpContext);

/*
 * Callback for EnumAddressTypes()
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL *LPDPLENUMADDRESSTYPESCALLBACK)(REFGUID guidDataType, object* lpContext, uint dwFlags);
public delegate bool LPDPLENUMADDRESSTYPESCALLBACK(REFGUID guidDataType, object lpContext, uint dwFlags);

/*
 * Callback for EnumLocalApplications()
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDPLENUMLOCALAPPLICATIONSCALLBACK)(const DPLAPPINFO FAR * lpAppInfo, object* lpContext, uint dwFlags);
public delegate bool LPDPLENUMLOCALAPPLICATIONSCALLBACK(DPLAPPINFO lpAppInfo, object lpContext, uint dwFlags);


/****************************************************************************
 *
 * DirectPlayLobby API Prototypes
 *
 ****************************************************************************/
#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectPlayLobbyCreate DirectPlayLobbyCreateW
#define DirectPlayLobbyCreate
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectPlayLobbyCreate DirectPlayLobbyCreateA
#define DirectPlayLobbyCreate
#endif // UNICODE

/****************************************************************************
 *
 * DirectPlayLobby Flags
 *
 ****************************************************************************/

/*
 *	This flag is used by IDirectPlayLobby->WaitForConnectionSettings to
 *	cancel a current wait that is in progress.
 */


/*
 *	This is a message flag used by ReceiveLobbyMessage.  It can be
 *	returned in the dwMessageFlags parameter to indicate a message from
 *	the system.
 */

/*
 *	This is a message flag used by ReceiveLobbyMessage and SendLobbyMessage.
 *  It is used to indicate that the message is a standard lobby message.
 *  DPLMSG_SETPROPERTY, DPLMSG_SETPROPERTYRESPONSE, DPLMSG_GETPROPERTY,
 *	DPLMSG_GETPROPERTYRESPONSE
 */

/*
 *  Lobbyable Application registration flags
 */

/*
 *  Applications registered with this flag will not show up when
 *  applications are enumerated in the lobby.  This application
 *  will only be able to be launched by a lobby client that already
 *  knows about the application.
 */

/*
 *  Applications registered with this flag want voice to automatically
 *  be enabled for their application.  All players will be launched into
 *  an 'n'-way voice conference when the application is started.  The 
 *  user will be able to enable this flag for existing non-voice 
 *  directplay applications.
 */

/*
 * Applications that do their own voice conferencing should register with
 * this flag to avoid allowing the user to enable other voice chat 
 * capabilites during the same session.  This is to avoid users forcing
 * the DPLAPP_AUTOVOICE flag for the application.
 */

/****************************************************************************
 *
 * DirectPlayLobby messages and message data structures
 *
 * All system messages have a dwMessageFlags value of DPLMSG_SYSTEM returned
 * from a call to ReceiveLobbyMessage.
 *
 * All standard messages have a dwMessageFlags value of DPLMSG_STANDARD returned
 * from a call to ReceiveLobbyMessage.
 *
 ****************************************************************************/

/*
 * DPLMSG_GENERIC
 * Generic message structure used to identify the message type.
 */
public class _DPLMSG_GENERIC
{
    public uint dwType; // Message type
}

/*
 * DPLMSG_SYSTEMMESSAGE
 * Generic message format for all system messages --
 * DPLSYS_CONNECTIONSETTINGSREAD, DPLSYS_DPLYCONNECTSUCCEEDED,
 * DPLSYS_DPLAYCONNECTFAILED, DPLSYS_APPTERMINATED, DPLSYS_NEWCONNECTIONSETTINGS
 */
public class _DPLMSG_SYSTEMMESSAGE
{
    public uint dwType; // Message type
    public GUID guidInstance = new GUID(); // Instance GUID of the dplay session the message corresponds to
}

/*
 *  DPLMSG_SETPROPERTY
 *  Standard message sent by an application to a lobby to set a
 *  property
 */
public class _DPLMSG_SETPROPERTY
{
    public uint dwType; // Message type
    public uint dwRequestID; // Request ID (DPL_NOCONFIRMATION if no confirmation desired)
    public GUID guidPlayer = new GUID(); // Player GUID
    public GUID guidPropertyTag = new GUID(); // Property GUID
    public uint dwDataSize; // Size of data
    public uint[] dwPropertyData = new uint[1]; // Buffer containing data
}


/*
 *  DPLMSG_SETPROPERTYRESPONSE
 *  Standard message returned by a lobby to confirm a 
 *  DPLMSG_SETPROPERTY message.
 */
public class _DPLMSG_SETPROPERTYRESPONSE
{
    public uint dwType; // Message type
    public uint dwRequestID; // Request ID
    public GUID guidPlayer = new GUID(); // Player GUID
    public GUID guidPropertyTag = new GUID(); // Property GUID
    public int hr; // Return Code
}

/*
 *  DPLMSG_GETPROPERTY
 *  Standard message sent by an application to a lobby to request
 *	the current value of a property
 */
public class _DPLMSG_GETPROPERTY
{
    public uint dwType; // Message type
    public uint dwRequestID; // Request ID
    public GUID guidPlayer = new GUID(); // Player GUID
    public GUID guidPropertyTag = new GUID(); // Property GUID
}

/*
 *  DPLMSG_GETPROPERTYRESPONSE
 *  Standard message returned by a lobby in response to a
 *	DPLMSG_GETPROPERTY message.
 */
public class _DPLMSG_GETPROPERTYRESPONSE
{
    public uint dwType; // Message type
    public uint dwRequestID; // Request ID
    public GUID guidPlayer = new GUID(); // Player GUID
    public GUID guidPropertyTag = new GUID(); // Property GUID
    public int hr; // Return Code
    public uint dwDataSize; // Size of data
    public uint[] dwPropertyData = new uint[1]; // Buffer containing data
}

/*
 *  DPLMSG_NEWSESSIONHOST
 *  Standard message returned by a lobby in response to a
 *	the session host migrating to a new client
 */
public class _DPLMSG_NEWSESSIONHOST
{
    public uint dwType; // Message type
    public GUID guidInstance = new GUID(); // GUID Instance of the session
}


/******************************************
 *
 *	DirectPlay Lobby message dwType values
 *
 *****************************************/

/*
 *  The application has read the connection settings.
 *  It is now O.K. for the lobby client to release
 *  its IDirectPlayLobby interface.
 */

/*
 *  The application's call to DirectPlayConnect failed
 */

/*
 *  The application has created a DirectPlay session.
 */

/*
 *  The application has terminated.
 */

/*
 *  The message is a DPLMSG_SETPROPERTY message.
 */

/*
 *  The message is a DPLMSG_SETPROPERTYRESPONSE message.
 */

/*
 *  The message is a DPLMSG_GETPROPERTY message.
 */

/*
 *  The message is a DPLMSG_GETPROPERTYRESPONSE message.
 */

/*
 *  The message is a DPLMSG_NEWSESSIONHOST message.
 */

/*
 *  New connection settings are available.
 */

/*
 *  The Lobby Client has released the DirectPlayLobby Interface
 */

/****************************************************************************
 *
 * DirectPlay defined property GUIDs and associated data structures
 *
 ****************************************************************************/

/*
 * DPLPROPERTY_MessagesSupported
 *
 * Request whether the lobby supports standard.  Lobby with respond with either
 * TRUE or FALSE or may not respond at all.
 * 
 * Property data is a single BOOL with TRUE or FALSE
 */
// {762CCDA1-D916-11d0-BA39-00C04FD7ED67}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPLPROPERTY_MessagesSupported, 0x762ccda1, 0xd916, 0x11d0, 0xba, 0x39, 0x0, 0xc0, 0x4f, 0xd7, 0xed, 0x67);

/*
 * DPLPROPERTY_LobbyGuid
 *
 * Request the GUID that identifies the lobby software that the application
 * is communicating with.
 *
 * Property data is a single GUID.
 */
// {F56920A0-D218-11d0-BA39-00C04FD7ED67}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPLPROPERTY_LobbyGuid, 0xf56920a0, 0xd218, 0x11d0, 0xba, 0x39, 0x0, 0xc0, 0x4f, 0xd7, 0xed, 0x67);

/*
 * DPLPROPERTY_PlayerGuid
 *
 * Request the GUID that identifies the player on this machine for sending
 * property data back to the lobby.
 *
 * Property data is the DPLDATA_PLAYERDATA structure
 */
// {B4319322-D20D-11d0-BA39-00C04FD7ED67}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPLPROPERTY_PlayerGuid, 0xb4319322, 0xd20d, 0x11d0, 0xba, 0x39, 0x0, 0xc0, 0x4f, 0xd7, 0xed, 0x67);

/*
 * DPLDATA_PLAYERGUID
 *
 * Data structure to hold the GUID of the player and player creation flags
 * from the lobby.
 */
public class _DPLDATA_PLAYERGUID
{
    public GUID guidPlayer = new GUID();
    public uint dwPlayerFlags;
}

/*
 * DPLPROPERTY_PlayerScore
 *
 * Used to send an array of long integers to the lobby indicating the 
 * score of a player.
 *
 * Property data is the DPLDATA_PLAYERSCORE structure.
 */
// {48784000-D219-11d0-BA39-00C04FD7ED67}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPLPROPERTY_PlayerScore, 0x48784000, 0xd219, 0x11d0, 0xba, 0x39, 0x0, 0xc0, 0x4f, 0xd7, 0xed, 0x67);

/*
 * DPLDATA_PLAYERSCORE
 *
 * Data structure to hold an array of long integers representing a player score.
 * Application must allocate enough memory to hold all the scores.
 */
public class _DPLDATA_PLAYERSCORE
{
    public uint dwScoreCount;
    public int[] Score = new int[1];
}

/****************************************************************************
 *
 * DirectPlay Address ID's
 *
 ****************************************************************************/

/* DirectPlay Address
 *
 * A DirectPlay address consists of multiple chunks of data, each tagged
 * with a GUID signifying the type of data in the chunk. The chunk also
 * has a length so that unknown chunk types can be skipped.
 *
 * The EnumAddress() function is used to parse these address data chunks.
 */

/*
 * DPADDRESS
 *
 * Header for block of address data elements
 */
public class _DPADDRESS
{
    public GUID guidDataType = new GUID();
    public uint dwDataSize;
}


/*
 * DPAID_TotalSize
 *
 * Chunk is a DWORD containing size of entire DPADDRESS structure
 */

// {1318F560-912C-11d0-9DAA-00A0C90A43CB}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_TotalSize, 0x1318f560, 0x912c, 0x11d0, 0x9d, 0xaa, 0x0, 0xa0, 0xc9, 0xa, 0x43, 0xcb);

/*
 * DPAID_ServiceProvider
 *
 * Chunk is a GUID describing the service provider that created the chunk.
 * All addresses must contain this chunk.
 */

// {07D916C0-E0AF-11cf-9C4E-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_ServiceProvider, 0x7d916c0, 0xe0af, 0x11cf, 0x9c, 0x4e, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

/*
 * DPAID_LobbyProvider
 *
 * Chunk is a GUID describing the lobby provider that created the chunk.
 * All addresses must contain this chunk.
 */

// {59B95640-9667-11d0-A77D-0000F803ABFC}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_LobbyProvider, 0x59b95640, 0x9667, 0x11d0, 0xa7, 0x7d, 0x0, 0x0, 0xf8, 0x3, 0xab, 0xfc);

/*
 * DPAID_Phone and DPAID_PhoneW
 *
 * Chunk is a string containing a phone number (i.e. "1-800-555-1212")
 * in ANSI or UNICODE format
 */

// {78EC89A0-E0AF-11cf-9C4E-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_Phone, 0x78ec89a0, 0xe0af, 0x11cf, 0x9c, 0x4e, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

// {BA5A7A70-9DBF-11d0-9CC1-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_PhoneW, 0xba5a7a70, 0x9dbf, 0x11d0, 0x9c, 0xc1, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

/*
 * DPAID_Modem and DPAID_ModemW
 *
 * Chunk is a string containing a modem name registered with TAPI
 * in ANSI or UNICODE format
 */

// {F6DCC200-A2FE-11d0-9C4F-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_Modem, 0xf6dcc200, 0xa2fe, 0x11d0, 0x9c, 0x4f, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

// {01FD92E0-A2FF-11d0-9C4F-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_ModemW, 0x1fd92e0, 0xa2ff, 0x11d0, 0x9c, 0x4f, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

/*
 * DPAID_Inet and DPAID_InetW
 *
 * Chunk is a string containing a TCP/IP host name or an IP address
 * (i.e. "dplay.microsoft.com" or "137.55.100.173") in ANSI or UNICODE format
 */

// {C4A54DA0-E0AF-11cf-9C4E-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_INet, 0xc4a54da0, 0xe0af, 0x11cf, 0x9c, 0x4e, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

// {E63232A0-9DBF-11d0-9CC1-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_INetW, 0xe63232a0, 0x9dbf, 0x11d0, 0x9c, 0xc1, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

/*
 * DPAID_InetPort
 *
 * Chunk is the port number used for creating the apps TCP and UDP sockets.
 * WORD value (i.e. 47624).
 */

// {E4524541-8EA5-11d1-8A96-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_INetPort, 0xe4524541, 0x8ea5, 0x11d1, 0x8a, 0x96, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);

#if BIGMESSAGEDEFENSE
#endif

/*
 * DPCOMPORTADDRESS
 *
 * Used to specify com port settings. The constants that define baud rate,
 * stop bits and parity are defined in WINBASE.H. The constants for flow
 * control are given below.
 */


public class _DPCOMPORTADDRESS
{
    public uint dwComPort; // COM port to use (1-4)
    public uint dwBaudRate; // baud rate (100-256k)
    public uint dwStopBits; // no. stop bits (1-2)
    public uint dwParity; // parity (none, odd, even, mark)
    public uint dwFlowControl; // flow control (none, xon/xoff, rts, dtr)
}


/*
 * DPAID_ComPort
 *
 * Chunk contains a DPCOMPORTADDRESS structure defining the serial port.
 */

// {F2F0CE00-E0AF-11cf-9C4E-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPAID_ComPort, 0xf2f0ce00, 0xe0af, 0x11cf, 0x9c, 0x4e, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

/****************************************************************************
 *
 * 	dplobby 1.0 obsolete definitions
 *	Included for compatibility only.
 *
 ****************************************************************************/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPLAD_SYSTEM DPLMSG_SYSTEM


#if __cplusplus
#endif // __cplusplus

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(default:4201)


