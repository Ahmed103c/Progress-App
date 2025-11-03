<template>
    <div class="users-status">
        <h1>
            User Status Page
        </h1>
        <div class="table-container">
            <div class="side-labels-container">
                <div class="side-labels" v-for="value in 5">{{ value }}</div>
            </div>
            <div class="labels">
                <div class="titles" v-for="days in daysInNovember">{{ days }}
                    <div class="users-data" v-for="users in 5" :class="{ sucess : (users % 2 === 0) , failure : (users % 2 !== 0)  }"></div>
                </div>

            </div>
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

.table-container{
    display: flex;
}

.labels{
        background: rgba(255, 255, 255, 0.2);
        border-radius: 10px;
        padding: 10px 10px;
        box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(5px);
        -webkit-backdrop-filter: blur(5px);
        border: 1px solid rgba(0, 0, 0, 0.3);
}

.side-labels-container{
    display: flex;
    flex-direction: column;
    gap : 16px;
    justify-content: flex-end;
    margin-right: 20px;
    background: rgba(255, 255, 255, 0.2);
    border-radius: 10px;
    padding: 10px 10px;
    box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
    backdrop-filter: blur(5px);
    -webkit-backdrop-filter: blur(5px);
    border: 1px solid rgba(0, 0, 0, 0.3);
}

.side-labels{
    font-family: 'Red Hat Display', sans-serif;
    color: #ffffff;
    font-size: 14px;

}

.users-data{
    font-family: 'Red Hat Display', sans-serif;
    color: #ffffff;
    font-size: 14px;
    width: 15px;
    height: 15px;
    border-radius: 2px;
    background-color: rgb(255, 98, 98);
    box-shadow: 1px 1px 3px #ff2323;
}

.failure {
    background-color: rgb(255, 98, 98);
    box-shadow: 1px 1px 3px #ff2323;
}

.sucess {
    background-color: rgb(103, 234, 74);
    box-shadow: 1px 1px 3px #32ff23;
}

.titles{
    font-family: 'Red Hat Display', sans-serif;
    color: #ffffff;
    font-size: 14px;
}


.users-status {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    height: 100vh;
}
.labels {
    display: flex;
    gap : 10px;
    justify-content: center;
    align-items: center;
}

.titles {
    display: flex;
    flex-direction: column;
    gap : 20px;
    justify-content: center;
    align-items: center;
}

</style>


<script setup lang="ts">


const daysInNovember = 30;

</script>