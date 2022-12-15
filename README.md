# Realm-MAUI-Iphone-HotRestart-Issue


Issue: Code runs fine on Android, but on a physical iPhone (through hot reload and Windows) it crashes.

How to test the issue:

1. Download latest Visual Studio 2022 for Windows.

2. Test the app first on Android phone or emulator to make sure it works.

3. Use a physical iPhone and follow these directions: https://learn.microsoft.com/en-us/dotnet/maui/deployment/hot-restart?view=net-maui-6.0

4. Click the button in the view, and the error should show in terminal/output.

Disclaimer:
I am not 100% sure if the issue is caused by Realm. But when you click the button on an physical iPhone, to initialize Realm, this error pops up:
An error occurred: 'realm-wrappers'. Callstack: ' at Realms.SynchronizationContextScheduler.Initialize()
at Realms.NativeCommon.Initialize()
at Realms.Sync.AppHandle..cctor()'
The app has been terminated.
