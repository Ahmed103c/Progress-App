<template>
    <div class = "statusoftheday">
        <h1>
            Welcome user, today is day {{ new Date().getDate() }} of No Nut November!
        </h1>
        <div class="choises">
            <button @click="navigateTo('/usersStatus')">Log Success</button>
            <button @click="navigateTo('/usersStatus')">Log Failure</button>
        </div>
    </div>

</template>

<style lang="css">

    h1 {
        font-family: 'Red Hat Display', sans-serif;
        background: rgba(255, 255, 255, 0.2);
        color: #ffffff;
        padding: 20px;
        border-radius: 10px;
        box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(5px);
        -webkit-backdrop-filter: blur(5px);
        border: 1px solid rgba(0, 0, 0, 0.3);
    }

    .statusoftheday {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        height: 100vh;
    }
    .choises {
        margin-top: 20px;
        display: flex;
        gap: 20px;
    }
    button {
        font-family: 'Red Hat Display', sans-serif;
        padding: 10px 20px;
        font-size: 16px;
        background: rgba(255, 255, 255, 0.2);
        border-radius: 5px;
        box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(5px);
        -webkit-backdrop-filter: blur(5px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        color: #ffffff;
        cursor: pointer;
    }



</style>