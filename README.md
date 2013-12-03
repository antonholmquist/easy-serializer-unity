# Easy Serializer for Unity

This project aims to make object serialization in Unity as simple as possible while supporting all platforms.

## Platform Support

PC/Mac/Linux standalones, iOS, Android.


## Usage

**Serialize object to file**

```
EasySerializer.SerializeObjectToFile(anObject, filePath);
```

**Deserialize object to file**

```
Object anObject = EasySerializer.DeserializeObjectFromFile(filePath);
```

## Unity Peristent File Path

In case you didn't already know, a persistent file path can be aquired in Unity like this:

```
string filePath = Application.persistentDataPath + '/object.data';
```

## Further Information

Object serializing in Unity can be surprisingly awkward. The `BinaryFormatter` class requires a `VersionDeserializationBinder` instance, and even after that, it breaks on iOS due to `ExecutionEngineException: Attempting to JIT compile method 'List 1__TypeMetadata:.ctor ()' while running with --aot-only.`.

## Links

http://answers.unity3d.com/questions/8480/how-to-scrip-a-saveload-game-option.html
http://answers.unity3d.com/questions/30930/why-did-my-binaryserialzer-stop-working.html?sort=oldest

## Author

Anton Holmquist
