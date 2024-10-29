document.querySelector(".button").addEventListener("click",
    async function () {
        var resposnse = await fetch("friends-list", { method: "GET" });
        var body = await resposnse.text();
        document.querySelector("#friends").innerHTML = body;
    }
);