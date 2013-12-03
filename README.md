# Easy Serializer for Unity

This project aims to make object serialization in Unity as simple as possible while supporting all platforms. 

## Platform Support

PC/Mac/Linux standalones, iOS, Android.

## Usage

### 1. Preparing the object for serialization

First, you need to make sure that the class you want to serialize adheres to one of the two following:

* For automatically serialization, mark the class with the **SerializableAttribute** as in `ExampleObjectSerializableAttribute.cs`.

* For a fine-grained serialization process, implement the **ISerializable** interface as in `ExampleObjectISerializable.cs`.

### 2. Serialization / Deserialization


**Serialize object to file**

```
EasySerializer.SerializeObjectToFile(serializableObject, filePath);
```

**Deserialize object from file**

```
Object anObject = EasySerializer.DeserializeObjectFromFile(filePath);
```

## Unity Persistent File Path

In case you didn't already know, a persistent file path can be aquired in Unity like this:

```
string filePath = Application.persistentDataPath + '/object.data';
```

## Protip: iOS JIT Exception Fix

Standard object serializing in Unity on iOS devices breaks with this exception:  `ExecutionEngineException: Attempting to JIT compile method 'List 1__TypeMetadata:.ctor ()' while running with --aot-only.`.

To avoid this in your own code, add this line before doing any serialization it should work:

```
Environment.SetEnvironmentVariable("MONO_REFLECTION_SERIALIZER", "yes");
```

## Links

- http://answers.unity3d.com/questions/8480/how-to-scrip-a-saveload-game-option.html
- http://answers.unity3d.com/questions/30930/why-did-my-binaryserialzer-stop-working.html?sort=oldest

## Author

Anton Holmquist
