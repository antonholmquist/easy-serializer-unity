/*
 * EasySerializer
 *
 * Author: Anton Holmquist
 * Copyright (c) 2013 Anton Holmquist. All rights reserved.
 * http://github.com/antonholmquist/easy-serializer-unity
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

/* ExampleObjectISerializable
 * 
 * Example of a class that will be serialized with fine-grained control. 
 */

using System.Runtime.Serialization;

[Serializable ()]

public class ExampleObjectISerializable : ISerializable {

	public string m_text_1;
	public string m_text_2;

	public ExampleObjectISerializable (SerializationInfo info, StreamingContext context) {
		m_text_1 = info.GetValue("m_text_1", typeof(string)) as string;
		m_text_2 = info.GetValue("m_text_2", typeof(string)) as string;
	}
	
	public void GetObjectData(SerializationInfo info, StreamingContext context) {
		info.AddValue("m_text_1", m_text_1);
		info.AddValue("m_text_2", m_text_2);
	}
}
