class MyClass
{
  private readonly string value;

  // コンストラクタのみで代入可能
  public MyClass(string value) {
    this.value = value;
  }

  public void ChangeValue(string value) {
    // コンパイルエラー
    this.value = value;
  }
}
