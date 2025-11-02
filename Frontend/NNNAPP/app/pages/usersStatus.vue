<template>
    <div class="users-status">
        <h1>
            User Status Page
        </h1>
        <div class="table-users" id="toplabels">
            <div class="toplabeles" v-for="integer in Array.from({ length: 30 }, (_, i) => i + 1)" :key="integer">
                <span>Day {{ integer }}</span>
            </div>
        </div>
        <div class="users">
            <div class="table-users" v-for="user in ['User1', 'User2', 'User3']" :key="user">
                <div class="toplabeles">
                    <span>{{ user }}</span>
                </div>
                <div class="toplabeles" v-for="integer in Array.from({ length: 30 }, (_, i) => i + 1)" :key="integer">
                    <span>Status {{ integer }}</span>
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

.users-status {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    height: 100vh;
}

.table-users {
        gap: 5px;
        display: flex;
        flex-direction: row;
        align-items: center;
        margin-left: 10px;
        margin-right: 10px;
        max-width: calc(100vw - 50px);
        overflow-x: scroll;
        overflow-y: hidden;

        background: rgba(255, 255, 255, 0.2);
        border-radius: 5px;
        box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(5px);
        -webkit-backdrop-filter: blur(5px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        margin: 8px;
    }
    .toplabeles{
        margin: 10px;
        width: 60px;
    }
    span {
        font-family: 'Red Hat Display', sans-serif;
        color: #ffffff;
        white-space: nowrap;
        width: 60px;
    }
    ::-webkit-scrollbar {
        height: 0px;
    }

.users{
    margin-top: 20px;
}

#toplabels {
    margin-top: 20px;
    margin-left: 80px;
    max-width: calc(100vw - 120px);
}
</style>


<script setup lang="ts">


const daysInNovember = 30;

</script>