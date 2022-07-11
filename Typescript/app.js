"use strict";
let botao = document.getElementById("button");
let input1 = document.getElementById("input1");
let input2 = document.getElementById("input2");
function adicionarNumeros(num1, num2) {
    return num1 + num2;
}
botao === null || botao === void 0 ? void 0 : botao.addEventListener("click", () => {
    console.log(
        adicionarNumeros(Number(input1.value), Number(input2.value))
    );
});
