%namespace M11J1

Ident									[a-zA-Z_][a-zA-Z0-9_]*
OctalDigit								[0-7]
HexDigit								[0-9a-fA-F]
BinaryDigit								0|1
IntegerTypeSuffix						1|L
NonZeroDigit							[1-9]
Underscores								\_+

/* 3.3. Unicode Escapes */
UnicodeEscape							\\u{HexDigit}{4}
InputCharacter							[^\r\n]

/* 3.7. Comments */
CommentStart							(\/\*)
CommentEnd								(\*\/)
NotStarNotSlash							[^\*\/]
TraditionalComment						{CommentStart}{NotStarNotSlash}*{CommentEnd}
EndOfLineComment						\/\/{InputCharacter}*
Comment									{TraditionalComment}|{EndOfLineComment}

/* 3.10.1 DecimalIntegerLiteral */
Digit									0|{NonZeroDigit}
DigitOrUnderscore						{Digit}|{Underscores}
DigitsAndUnderscores					{DigitOrUnderscore}+
Digits									{Digit}|{Digit}{DigitsAndUnderscores}?{Digit}
DecimalNumeral							0|{NonZeroDigit}{Digits}?|{NonZeroDigit}{Underscores}{Digits}
DecimalIntegerLiteral					{DecimalNumeral}{IntegerTypeSuffix}?

/* 3.10.1 HexIntegerLiteral */
HexDigitOrUnderscore					{HexDigit}|\_
HexDigitsAndUnderscores					{HexDigitOrUnderscore}+
HexDigits								{HexDigit}|{HexDigit}{HexDigitsAndUnderscores}?{HexDigit}
HexNumeral								0x{HexDigits}|0X{HexDigits}
HexIntegerLiteral						{HexNumeral}{IntegerTypeSuffix}?

/* 3.10.1 OctalIntegerLiteral */
OctalDigitOrUnderscore					{OctalDigit}|\_
OctalDigitsAndUnderscores				{OctalDigitOrUnderscore}+
OctalDigits								{OctalDigit}|{OctalDigit}{OctalDigitsAndUnderscores}?{OctalDigit}
OctalNumeral							0{OctalDigits}|0{Underscores}{OctalDigits}
OctalIntegerLiteral						{OctalNumeral}{IntegerTypeSuffix}?

/* 3.10.1 BinaryIntegerLiteral */
BinaryDigitOrUnderscore					{BinaryDigit}|\_
BinaryDigitsAndUnderscores				{BinaryDigitOrUnderscore}+
BinaryDigits							{BinaryDigit}|{BinaryDigit}{BinaryDigitsAndUnderscores}?{BinaryDigit}
BinaryNumeral							0b{BinaryDigits}|0B{BinaryDigits}
BinaryIntegerLiteral					{BinaryNumeral}{IntegerTypeSuffix}?

/* 3.10.2. DecimalFloatingPointLiteral */
ExponentIndicator						e|E
Sign									\+|\-
SignedInteger							{Sign}?{Digits}
FloatTypeSuffix							f|F|d|D
ExponentPart							{ExponentIndicator}{SignedInteger}
DecimalFloatingPointLiteral_Opt1		{Digits}\.{Digits}?{ExponentPart}?{FloatTypeSuffix}?
DecimalFloatingPointLiteral_Opt2		\.{Digits}{ExponentPart}?{FloatTypeSuffix}?
DecimalFloatingPointLiteral_Opt3		{Digits}{ExponentPart}{FloatTypeSuffix}?
DecimalFloatingPointLiteral_Opt4		{Digits}{ExponentPart}?{FloatTypeSuffix}
DecimalFloatingPointLiteral				{DecimalFloatingPointLiteral_Opt1}|{DecimalFloatingPointLiteral_Opt2}|{DecimalFloatingPointLiteral_Opt3}|{DecimalFloatingPointLiteral_Opt4}

/* 3.10.2. HexadecimalFloatingPointLiteral */
BinaryExponentIndicator					p|P
BinaryExponent							{BinaryExponentIndicator}{SignedInteger}
HexSignificand							({HexNumeral}\.?)|(0x{HexDigits}?\.{HexDigits})|(0X{HexDigits}?\.{HexDigits})
HexadecimalFloatingPointLiteral			{HexSignificand}{BinaryExponent}{FloatTypeSuffix}?

/* 3.10.6. Escape Sequences for Character and String Literals */
EscapeSequence							\\[btnfr\"\'\\]
OctalEscape								\\([1-3]{OctalDigit}{2}|{OctalDigit}{1,2})

CharacterLiteral						\'({EscapeSequence}|{OctalEscape}|{UnicodeEscape}|{InputCharacter})\'
/* 3.10.5. String Literals */
StringLiteral							\"({EscapeSequence}|{OctalEscape}|{UnicodeEscape}|{InputCharacter})*\"

IntegerLiteral							{DecimalIntegerLiteral}|{HexIntegerLiteral}|{OctalIntegerLiteral}|{BinaryIntegerLiteral}
FloatingPointLiteral					{DecimalFloatingPointLiteral}|{HexadecimalFloatingPointLiteral}

/* 3.8 Identifier */
Identifier								[a-zA-Z_][a-zA-Z0-9_]*

%{
int lines = 1;
%}

%%

/* 3.9 Token -> Keywords */
abstract								{ return (int)Tokens.Abstract; }
assert									{ return (int)Tokens.Assert; }
boolean									{ return (int)Tokens.Boolean; }
break								    { return (int)Tokens.Break; }
byte								    { return (int)Tokens.Byte; }
case								    { return (int)Tokens.Case; }
catch								    { return (int)Tokens.Catch; }
char									{ return (int)Tokens.Char; }
class									{ return (int)Tokens.Class; }
const									{ return (int)Tokens.Const; }
continue								{ return (int)Tokens.Continue; }
default									{ return (int)Tokens.Default; }
do										{ return (int)Tokens.Do; }
double									{ return (int)Tokens.Double; }
else									{ return (int)Tokens.Else; }
enum									{ return (int)Tokens.Enum; }
extends									{ return (int)Tokens.Extends; }
final									{ return (int)Tokens.Final; }
finally									{ return (int)Tokens.Finally; }
float									{ return (int)Tokens.Float; }
for										{ return (int)Tokens.For; }
goto									{ return (int)Tokens.Goto; }
if										{ return (int)Tokens.If; }
implements								{ return (int)Tokens.Implements; }
import									{ return (int)Tokens.Import; }
instanceof								{ return (int)Tokens.InstanceOf; }
int										{ return (int)Tokens.Int; }
interface								{ return (int)Tokens.Interface; }
long									{ return (int)Tokens.Long; }
native									{ return (int)Tokens.Native; }
new										{ return (int)Tokens.New; }
package									{ return (int)Tokens.Package; }
private									{ return (int)Tokens.Private; }
protected								{ return (int)Tokens.Protected; }
public									{ return (int)Tokens.Public; }
return									{ return (int)Tokens.Return; }
short									{ return (int)Tokens.Short; }
static									{ return (int)Tokens.Static; }
strictfp								{ return (int)Tokens.Strictfp; }
super									{ return (int)Tokens.Super; }
switch									{ return (int)Tokens.Switch; }
synchronized							{ return (int)Tokens.Synchronized; }
this									{ return (int)Tokens.This; }
throw									{ return (int)Tokens.Throw; }
throws									{ return (int)Tokens.Throws; }
transient								{ return (int)Tokens.Transient; }
try										{ return (int)Tokens.Try; }
void									{ return (int)Tokens.Void; }
volatile								{ return (int)Tokens.Volatile; }
while									{ return (int)Tokens.While; }     
true|false								{ return (int)Tokens.BooleanLiteral; }     
null									{ return (int)Tokens.NullLiteral; }

/* 3.5 Token -> Character Literals */
{CharacterLiteral}						{ yylval.c = char.Parse(yytext); return (int)Tokens.CharacterLiteral; }

/* 3.6 Token -> String Literals */
{StringLiteral}							{ yylval.name = yytext; return (int)Tokens.StringLiteral; }

/* 3.6 InputElement -> Whitespace */
[\n]									{ lines++;    }
[ \t\r]									/* ignore other whitespace */

/* 3.7 InputElement -> Comments */
{Comment}								/* skip comments */

/* 3.8 Token -> Identifier  */
{Identifier}							{ yylval.name = yytext; return (int)Tokens.Identifier; }

/* 3.10 Token -> IntegerLiteral */
{IntegerLiteral}						{ yylval.num = int.Parse(yytext); return (int)Tokens.IntegerLiteral; }

/*3.10.2. Floating-Point Literals*/
{FloatingPointLiteral}					{ yylval.fl = float.Parse(yytext); return (int)Tokens.FloatingPointLiteral; } 

/* 3.11 Separators */
"(" 							{return '(';}
")" 							{return ')';}
"{" 							{return '{';}
"}" 							{return '}';}
"[" 							{return '[';}
"]" 							{return ']';}
";" 							{return ';';}
"," 							{return ',';}
"." 							{return '.';}
"..." 							{return (int)Tokens.VariableArguments;}
"@" 							{return '@';}
"::" 							{return (int)Tokens.DoubleColon;}

/* Operator */
"=" 							{return '=';}
"<"								{return '<';}
">"								{return '>';}
"!"								{return '!';}
"~"								{return '~';}
":"								{return ':';}
"?"								{return '?';}
"->"							{return (int)Tokens.Selection;}
"=="							{return (int)Tokens.Equal;}
">="							{return (int)Tokens.GreaterOrEqual;}
"<="							{return (int)Tokens.LessOrEqual;}
"!="							{return (int)Tokens.NotEqual;}
"&&"							{return (int)Tokens.AndCondition;}
"||"							{return (int)Tokens.OrCondition;}
"++"                            { return (int) Tokens.OpInc; }
"--"                            { return (int) Tokens.OpDec; }
"+" 							{return '+';}
"-" 							{return '-';}
"*" 							{return '*';}
"/" 							{return '/';}
"&" 							{return '&';}
"|" 							{return '|';}
"^" 							{return '^';}
"%" 							{return '%';}
"<<" 							{return (int)Tokens.SignedLeftShift;}
">>" 							{return (int)Tokens.SignedRightShift;}
">>>" 							{return (int)Tokens.UnsignedRightShift;}
"+=" 							{return (int)Tokens.AddAnd;}
"-=" 							{return (int)Tokens.SubtractAnd;}
"*=" 							{return (int)Tokens.MultiplyAnd;}
"/=" 							{return (int)Tokens.DivideAnd;}
"&=" 							{return (int)Tokens.BitwiseAnd;}
"|=" 							{return (int)Tokens.BitwiseInclusiveOr;}
"^=" 							{return (int)Tokens.BitwiseExclusiveOr;}
"%="							{return (int)Tokens.ModulusAnd;}
"<<="							{return (int)Tokens.LeftShiftAnd;}
">>="							{return (int)Tokens.RightShiftAnd;}
">>>="							{return (int)Tokens.ShiftRightZeroFill;}

.	                            { 
									 throw new Exception(String.Format("unexpected character '{0}'", yytext)); 
								}
%%

public override void yyerror( string format, params object[] args )
{
    System.Console.Error.WriteLine("Error: line " + lines + ", " + format);
}
