package ru.geekbrains.lesson1.Store.InMemory;

import org.jetbrains.annotations.Contract;
import ru.geekbrains.lesson1.Store.Models.OrderEntity;

import java.util.Collection;

public class StoreService {

    @Contract(pure = true)
    public static void processOrders(Collection<OrderEntity> orders){
        for (OrderEntity order: orders) {
            //TODO: process orders ...
        }
    }

}
