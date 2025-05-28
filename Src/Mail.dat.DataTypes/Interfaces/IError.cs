// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
namespace Mail.dat
{
	public interface IError : IMaildatEntity
	{
		string Process { get; set; }
		string File { get; set; }
		string FieldName { get; set; }
		string FieldCode { get; set; }
		string DataType { get; set; }
		string Type { get; set; }
		int LineNumber { get; set; }
		int StartPosition { get; set; }
		int Length { get; set; }
		string Value { get; set; }
		string ErrorMessage { get; set; }
	}
}